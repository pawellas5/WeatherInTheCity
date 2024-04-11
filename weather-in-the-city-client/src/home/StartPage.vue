<template>
  <div class="startGame">
    <div class="loading">
      <img src="../assets/weather_desc/clear_sky_2.png" alt="weather">
      <img src="../assets/weather_desc/drizzle_2.png" alt="weather">
      <img src="../assets/weather_desc/mist_fog_2.png" alt="weather">
      <img src="../assets/weather_desc/overcast_clouds_2.png" alt="weather">
      <img src="../assets/weather_desc/rain_2.png" alt="weather" >
      <img src="../assets/weather_desc/scattered_clouds_2.png" alt="weather">
      <img src="../assets/weather_desc/snow_2.png" alt="weather">
      <img src="../assets/weather_desc/thunderstorm_2.png" alt="weather">
      <img src="../assets/weather_desc/scattered_clouds_2.png" alt="weather">
      <img src="../assets/positiveResult.png" alt="positive" >
      <img src="../assets/negativeResult.png" alt="negative" >
    </div>
    <button @click="startGame">
    Start Game
  </button>
  </div>

</template>

<script>
import { useRouter, onBeforeRouteLeave } from 'vue-router';
import getQuestion from '../shared/getQuestion';
import { useGameInfoStore, useGameDataStore } from '../store/index';

window.addEventListener('beforeunload', async () => { await useGameDataStore().removeCurrentGame(useGameDataStore().gameFlowId); });

export default {
  name: 'StartPage',
  setup() {
    useGameInfoStore().reset();
    const gameDataStore = useGameDataStore();
    const router = useRouter();

    let canLeave = false;
    function leave() { canLeave = true; }
    const promise = getQuestion();
    promise.then(() => { leave(); });

    const startGame = () => {
      promise.then(() => { router.push('/game'); });
    };

    onBeforeRouteLeave(async (to) => {
      if (to.path === '/game' || to.path === '/profile' || to.path === '/') {
        if (to.path !== '/game') await gameDataStore.removeCurrentGame(gameDataStore.gameFlowId);

        return canLeave;
      }

      return false;
    });

    return {
      startGame,
    };
  },

};

</script>

<style scoped>

.loading{
  display: none;
}

.startGame{

  width:100%;
  height:100%;
  display:flex;
  justify-content: center;
  align-items: center;

}
.startGame button{

    width:250px;
    height:100px;
    border-radius: 2rem;
    border:0;
    background-color: #ff7900;
    color:white;
    font-size: 2rem;
}
.startGame button:hover{
  cursor:pointer;
  background-color:#ff9300;

}

@media screen and (max-width: 430px ){

  .startGame button{
    height:90px;
    font-size: 1.9rem;
  }
}
@media screen and (max-width:390px){
  .startGame button{
    width:200px;
    height:65px;
    font-size: 1.6rem;
  }
}

@media screen and (max-width:360px){
  .startGame button{
    height:70px;
    font-size: 1.8rem;
  }
}

@media screen and (max-width:280px){
  .startGame button{
    width:180px;
    height:65px;
    font-size: 1.5rem;
  }
}
  </style>
