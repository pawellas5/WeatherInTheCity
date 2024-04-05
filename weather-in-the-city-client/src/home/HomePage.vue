<template>
  <div class="startGame">
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
  name: 'HomePage',
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
      if (to.path === '/game' || to.path === '/profile') {
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
  </style>
