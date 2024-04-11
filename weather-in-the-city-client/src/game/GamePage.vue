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

@media screen and (max-width: 1280px ){
  .degreeCelsius{
    font-size:8rem;
  }
}

@media screen and (max-width: 1080px ){
  .main{
    padding-top:2rem;
  }
.weather{
  border-radius: 0;
}

.degreeCelsius{
    font-size:6rem;
  }

  .cities{
  display:grid;
  grid-template-columns: 50% 50% ;
  grid-template-rows: 50% 50% ;
  justify-items: center;
  padding: 2.5rem 3rem 2.5rem 3rem;

}
.main .cities .btn{

  height:200px;
  width:350px;
  border-radius: 1.5rem;
  padding: 3.5rem 0 3.5rem 0;
}

}

@media screen and (max-width: 1024px ){

 .main .cities .btn{

height:150px;
width:300px;
padding: 3.5rem 0 3.5rem 0;
}

}

@media screen and (max-width: 1024px ) and (orientation: landscape){

 .main .cities .btn{
  width:200px;
  height:80px;
  font-size: 1.5rem;
  padding:0;
}
  .cities{
    display:flex;
flex-direction: row;
padding:0;
}
.otherInfo div{
  font-size: 1.5rem;
}
.temperature{
  font-size: 8rem ;
}
.cityName{
  padding-top:0.5rem;
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
.temperature{
    flex-direction:column-reverse;
  }
.icon{
  width:100%;
  height:50%;
  display:flex;
  justify-content: center;
}
.icon img{
  width:270px;
  height:270px;
}
.degreeCelsius{
  width:100%;
  height:50%;
  display:flex;
  justify-content: center;
  align-items: center;
  font-size:8rem;

}
.otherInfo{
  align-items: center;
}
.otherInfo div{
  width:70%;
}

}

@media screen and (max-width: 768px ){
.temperature{
font-size:8rem;
}
.countryName{
font-size:1.5rem;
}

.icon img{
  width:220px;
  height:220px;
}

.degreeCelsius{
  font-size:6rem;

}

.otherInfo div{
  width:80%;
}

.main .cities .btn{

height:100px;
width:300px;
padding: 1rem 0 1rem 0;
}
.cities{
padding: 2.5rem 3rem 2.5rem 3rem;
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
.degreeCelsius{
  font-size:4rem;

}
.icon img{
  width:160px;
  height:160px;
}
.otherInfo div{
  width:80%;
}

.main .cities .btn{

height:80px;
width:200px;
border-radius: 1.5rem;
padding: 1rem 0 1rem 0;
font-size:1.2rem;
}
.cities{
padding: 1rem 0 1rem 0;
}

}

@media screen and (max-width: 430px ){

.main .cities .btn{

  height:90px;
  width:160px;
  padding: 1rem 0 1rem 0;
  font-size:1.2rem;

}

}

@media screen and (max-width: 375px ){

.main .cities .btn{

  height:70px;
  width:160px;
  padding: 1rem 0 1rem 0;
  font-size:1.2rem;
}
.cities{
  padding: 1rem 0.2rem 1rem 0.2rem;
}
.degreeCelsius{
  font-size:3.5rem;
}
.icon img{
  width:110px;
  height:110px;
}

}

@media screen and (max-width: 280px ){
  .main{
    font-size: 0.9rem;
  }
  .temperature{
    font-size: 3.5rem;
  }

.countryName{
  font-size: 0.8rem;
}
.cityName{
  font-size:0.9rem;
}
.icon img{
  width:110px;
  height:110px;
}
.degreeCelsius{

  font-size:2.5rem;

}
.otherInfo{
  padding-right: 0.4rem;
}

.main .cities .btn{

  width:120px;
  height:60px;
  font-size: 2rem;
  padding: 1.2rem 0 1.2rem 0;
}
.cities{
  padding: 1.5rem 0 1.5rem 0;
}

}

</style>
