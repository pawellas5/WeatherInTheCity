<template >
    <div   class="main">
      <div   class="weather">
        <div class="temperature">
          {{Math.round(weather.main.temp)}}&deg;C
        </div>
        <div class="otherInfo">
          <div>Description: {{ weather.weather[0].description }}</div>
          <div>Pressure: {{ weather.main.pressure }} kpa</div>
          <div>Humidity: {{weather.main.humidity}}%</div>
          <div>Wind: {{weather.wind.speed}} km/h</div>
        </div>

      </div>
      <div class="cities">
        <button @click=" selectCity(0)" v-bind:class="[{btnColorCorrect:isCorrect[0]}
        ,{btnColorIncorrect:isIncorrect[0]},{btnColorGreyedOut:isGreyedOut[0]}]" class="btn">

          <div class=cityName>
            {{cities[0].cityName}}
          </div>
          <div class=countryName>
            ({{cities[0].countryName}})
          </div>

        </button>

        <button @click="selectCity(1)"  v-bind:class="[{btnColorCorrect:isCorrect[1]}
        ,{btnColorIncorrect:isIncorrect[1]},{btnColorGreyedOut:isGreyedOut[1]}]"  class="btn">

          <div class=cityName>
            {{cities[1].cityName}}
          </div>
          <div  class=countryName>
            ({{cities[1].countryName}})
          </div></button>

        <button @click="selectCity(2)"  v-bind:class="[{btnColorCorrect:isCorrect[2]}
        ,{btnColorIncorrect:isIncorrect[2]},{btnColorGreyedOut:isGreyedOut[2]}]"  class="btn">

          <div class=cityName>
            {{cities[2].cityName}}
          </div>
          <div class=countryName>
            ({{cities[2].countryName}})
          </div>

        </button>

        <button @click="selectCity(3)" v-bind:class="[{btnColorCorrect:isCorrect[3]}
        ,{btnColorIncorrect:isIncorrect[3]},{btnColorGreyedOut:isGreyedOut[3]}]" class="btn">

          <div class=cityName>
            {{cities[3].cityName}}
          </div>
          <div class=countryName>
            ({{cities[3].countryName}})
          </div>

        </button>

      </div>
    </div>

  </template>

<script>
import { storeToRefs } from 'pinia';
import { useRouter, onBeforeRouteLeave } from 'vue-router';
import getQuestion from '@/shared/getQuestion';
import { useGameDataStore, useGameInfoStore } from '../store/index';
import sleep from './sleep';
import {
  isCorrect, isIncorrect, isGreyedOut, setBtnFlags, resetBtnFlags,
} from './buttonFlags';

export default {
  name: 'GamePage',

  setup() {
    const router = useRouter();
    const gameDataStore = useGameDataStore();
    const gameInfoStore = useGameInfoStore();
    let ind = null;
    const { weather, cities } = storeToRefs(gameDataStore);

    async function selectCity(id) {
      ind = id;
      // console.log(`Points: ${gameInfoStore.points}`);
      // console.log(`QuestionNumber: ${gameInfoStore.questionNumber}`);

      setBtnFlags(id);

      await sleep(1000);
      if (gameInfoStore.questionNumber < gameInfoStore.questionTotal) {
        gameInfoStore.nextQuestion();

        await getQuestion(); // to the next question
      } else {
        // mark the end of the game and redirect to the result page
        gameInfoStore.questionNumber = gameInfoStore.questionTotal + 1;
        router.push({
          name: 'Result',

        });
      }
      resetBtnFlags();
    }

    onBeforeRouteLeave((to) => {
      if (gameInfoStore.questionNumber <= gameInfoStore.questionTotal) {
        if (to.name === 'Result') return false;
        // eslint-disable-next-line no-alert
        const answer = window.confirm(
          'Do you really want to leave and lose all your points?',
        );
        if (answer) {
          gameInfoStore.reset();
          return true;
        }
        return false;
      }
      return true; // when the game is over, go to the result page
    });

    return {
      gameDataStore,
      weather,
      cities,
      selectCity,
      isCorrect,
      isIncorrect,
      isGreyedOut,
      ind,

    };
  },
};
</script>

<style scoped>

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
  justify-content: center;
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
