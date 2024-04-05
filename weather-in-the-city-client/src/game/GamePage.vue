<template >
  <div   class="main">
    <div   class="weather">
      <div class="temperature">
        <div class="degreeCelsius">{{Math.round(weather.main.temp)}}&deg;C
        </div>
        <div v-if="isClearSky"  class="icon">
          <img src="../assets/weather_desc/clear_sky_2.png" alt="weather"></div>
        <div v-else-if="isDrizzle"  class="icon">
          <img src="../assets/weather_desc/drizzle_2.png" alt="weather"></div>
        <div v-else-if="isMistOrFog"  class="icon">
          <img src="../assets/weather_desc/mist_fog_2.png" alt="weather"></div>
        <div v-else-if="isOvercastClouds"  class="icon">
          <img src="../assets/weather_desc/overcast_clouds_2.png" alt="weather"></div>
        <div v-else-if="isRain" class="icon">
          <img src="../assets/weather_desc/rain_2.png" alt="weather" ></div>
        <div v-else-if="isScatteredOrBrokenClouds" class="icon">
          <img  src="../assets/weather_desc/scattered_clouds_2.png" alt="weather"></div>
        <div v-else-if="isSnow"  class="icon">
          <img src="../assets/weather_desc/snow_2.png" alt="weather"></div>
        <div v-else-if="isStorm"  class="icon">
          <img src="../assets/weather_desc/thunderstorm_2.png" alt="weather"></div>
        <div v-else  class="icon">
          <img src="../assets/weather_desc/scattered_clouds_2.png" alt="weather"></div>

      </div>
      <div class="otherInfo">
        <div>Description: {{ weather.weather[0].description }}</div>
        <div>Pressure: {{ weather.main.pressure }} kpa</div>
        <div>Humidity: {{weather.main.humidity}}%</div>
        <div>Wind: {{weather.wind.speed}} km/h</div>
      </div>

    </div>
    <div class="cities">
      <button @click=" selectCity(button1)" v-bind:class="[{btnColorCorrect:isCorrect[button1]}
      ,{btnColorIncorrect:isIncorrect[button1]},{btnColorGreyedOut:isGreyedOut[button1]}]"
        class="btn">

        <div class=cityName>
          {{cities[button1].cityName}}
        </div>
        <div class=countryName>
          ({{cities[button1].countryName}})
        </div>

      </button>

      <button @click="selectCity(button2)"  v-bind:class="[{btnColorCorrect:isCorrect[button2]}
      ,{btnColorIncorrect:isIncorrect[button2]},{btnColorGreyedOut:isGreyedOut[button2]}]"
        class="btn">

        <div class=cityName>
          {{cities[button2].cityName}}
        </div>
        <div  class=countryName>
          ({{cities[button2].countryName}})
        </div></button>

      <button @click="selectCity(button3)"  v-bind:class="[{btnColorCorrect:isCorrect[button3]}
      ,{btnColorIncorrect:isIncorrect[button3]},{btnColorGreyedOut:isGreyedOut[button3]}]"
        class="btn">

        <div class=cityName>
          {{cities[button3].cityName}}
        </div>
        <div class=countryName>
          ({{cities[button3].countryName}})
        </div>

      </button>

      <button @click="selectCity(button4)" v-bind:class="[{btnColorCorrect:isCorrect[button4]}
      ,{btnColorIncorrect:isIncorrect[button4]},{btnColorGreyedOut:isGreyedOut[button4]}]"
        class="btn">

        <div class=cityName>
          {{cities[button4].cityName}}
        </div>
        <div class=countryName>
          ({{cities[button4].countryName}})
        </div>

      </button>

    </div>
  </div>

</template>

<script>
import { storeToRefs } from 'pinia';
import { useRouter, onBeforeRouteLeave } from 'vue-router';
import getQuestion from '@/shared/getQuestion';
import { useAuth0 } from '@auth0/auth0-vue';
import { useGameDataStore, useGameInfoStore } from '../store/index';
import sleep from './sleep';
import setWeatherFlags from './weatherIconFlags';
import {
  isCorrect, isIncorrect, isGreyedOut, setBtnFlags, resetBtnFlags,
} from './buttonFlags';

window.addEventListener('beforeunload', async () => { await useGameDataStore().removeCurrentGame(useGameDataStore().gameFlowId); });

export default {
  name: 'GamePage',

  setup() {
    const router = useRouter();
    const gameDataStore = useGameDataStore();
    const gameInfoStore = useGameInfoStore();
    const { weather, cities } = storeToRefs(gameDataStore);

    const {
      isClearSky,
      isDrizzle,
      isMistOrFog,
      isOvercastClouds,
      isRain,
      isScatteredOrBrokenClouds,
      isSnow,
      isStorm,
    } = setWeatherFlags(weather);
    const { isAuthenticated } = useAuth0();

    const { getAccessTokenSilently } = useAuth0();

    const addUserStats = async (gameFlowID) => {
      const accessToken = await getAccessTokenSilently();
      await gameDataStore.addUserStats(accessToken, gameFlowID);
    };

    async function selectCity(id) {
      const selectedCity = cities.value[id].cityName;

      await gameDataStore.postAnswer(
        gameInfoStore.questionNumber,
        selectedCity,
        gameDataStore.gameFlowId,
      );
      setBtnFlags(id);

      await sleep(1000);
      if (gameInfoStore.questionNumber < gameInfoStore.questionTotal) {
        gameInfoStore.nextQuestion();
        await getQuestion(gameDataStore.gameFlowId); // to the next question
      } else {
        await gameDataStore.getPercentageResult(gameDataStore.gameFlowId);
        if (isAuthenticated.value) {
          await addUserStats(gameDataStore.gameFlowId);
        }
        await gameDataStore.removeCurrentGame(gameDataStore.gameFlowId);

        // mark the end of the game and redirect to the result page
        gameInfoStore.questionNumber = gameInfoStore.questionTotal + 1;
        router.push({
          name: 'Result',

        });
      }
      resetBtnFlags();
    }

    onBeforeRouteLeave(async (to) => {
      if (gameInfoStore.questionNumber <= gameInfoStore.questionTotal) {
        if (to.name === 'Result') return false;
        // eslint-disable-next-line no-alert
        const answer = window.confirm(
          'Do you really want to leave and lose all your points?',
        );
        if (answer) {
          gameInfoStore.reset();
          await gameDataStore.removeCurrentGame(gameDataStore.gameFlowId);
          return true;
        }
        return false;
      }
      return true; // when the game is over, go to the result page
    });

    return {
      button1: 0,
      button2: 1,
      button3: 2,
      button4: 3,
      isClearSky,
      isDrizzle,
      isMistOrFog,
      isOvercastClouds,
      isRain,
      isScatteredOrBrokenClouds,
      isSnow,
      isStorm,
      gameDataStore,
      weather,
      cities,
      selectCity,
      isCorrect,
      isIncorrect,
      isGreyedOut,

    };
  },
};
</script>

<style scoped>
.degreeCelsius{
  width:70%;
  display:flex;
  justify-content: center;
  align-items: center;

}
.icon{
  width:30%;
  display:flex;
  justify-content: left;
  align-content: center;
}
.icon img{
 width:180px;
}
.btn{
  width:250px;
  height:100px;
  border-radius: 2rem;
  border:0;
  background-color: #ff7900;
  color:white;
  font-size: 2rem;
}

.btnColorCorrect{
  pointer-events: none;
  background-color:green;

}

.btnColorIncorrect{
  pointer-events: none;
  background-color:red;

}

.btnColorGreyedOut{
  pointer-events: none;
  background-color:grey;

}
.btn:hover{
  cursor:pointer;
  /* background-color:#ff9300; */
  opacity:0.8;

}
.cities .btn{

display: flex;
flex-direction: column;
justify-content: center;
align-items: center;
}
.cityName{
height: 60%;
padding-top:1rem;
}
.countryName{
height:40%;
font-size:1.4rem;
}

.weather{
background-color: #e9eaed;
width:100%;
height:50%;
display:flex;
border-radius:2rem;

}

.temperature{
height:100%;
width:50%;
display: flex;
flex-direction: row;
justify-content: space-evenly;
align-items: center;
font-size: 10rem;
color:#ff7900;

}
.otherInfo{
height:100%;
width:50%;
display: flex;
flex-direction: column;
justify-content: space-evenly;
align-items: center;

}

.otherInfo div{
width:60%;
text-align: left;
color:#ff7900

}

.cities{
background-color:white;
width:100%;
height:50%;
display: flex;
justify-content: space-evenly;
align-items: center;
}
.main{
  width:100%;
  height: 100%;
  background-color: white;
  color:white;
  font-size:2rem;
  text-align:left;
  padding-top:4rem;
}

@media screen and (max-width: 1024px ){
  .main{
    padding-top:2rem;
  }

  .btn{
  width:500px;
  height:70px;
}
  .cities{
flex-direction: column;
}
.weather{
  border-radius: 0;
}
}

@media screen and (max-width: 1024px ) and (orientation: landscape){

  .btn{
  width:200px;
  height:80px;
  font-size: 1.5rem;
}
  .cities{
flex-direction: row;
}
.otherInfo div{
  font-size: 1.5rem;
}
.temperature{
  font-size: 8rem ;
}

}
@media screen and (max-width: 932px ) and (orientation: landscape){

.btn{
width:150px;
height:40px;
font-size: 0.8rem;
}

.otherInfo div{
font-size: 0.8rem;
}
.temperature{
font-size: 4rem ;
}

}

@media screen and (max-width: 932px ){

.cities .btn{
  padding:0.5rem 0 0.5rem 0;
  height:90px;
}
.cityName{
padding:0;
height:100%;

}
.countryName{
height:100%;
font-size:1.5rem;
}

}

@media screen and (max-width: 768px ){
.temperature{
font-size:8rem;
}
.cities .btn{
padding:0.5rem 0 0.5rem 0;
height:75px;
}
.countryName{
font-size:1.5rem;
}

}
@media screen and (max-width: 740px ) and (orientation: landscape){

.btn{
width:140px;
height:20px;
font-size: 0.6rem;
}
.otherInfo div{
font-size: 0.6rem;
}
.temperature{
font-size: 3rem ;
}

}

@media screen and (max-width: 540px ){

.cities .btn{
  width:220px;
  height:50px;
  font-size: 1.2rem;
}
  .main{
    padding-top:2rem;
    font-size: 1.2rem;
  }
  .temperature{
    font-size: 5rem;
  }
.countryName{
  font-size: 1rem;
}
  .cities{
flex-direction: column;
}

}

@media screen and (max-width: 375px ){
  .main{
    padding-top:2rem;
    font-size: 1.1rem;
  }
  .temperature{
    font-size: 4rem;
  }

.cities .btn{
  padding:0.5rem 0 0.5rem 0;
  height:45px;
  width:200px;
}

.countryName{
font-size:0.9rem;
}

}

@media screen and (max-width: 280px ){
  .main{
    font-size: 0.9rem;
  }
  .temperature{
    font-size: 3.5rem;
  }

.cities .btn{
  width:220px;
  height:40px;
}
.countryName{
  font-size: 0.8rem;
}
.cityName{
  font-size:0.9rem;
}
}

</style>
