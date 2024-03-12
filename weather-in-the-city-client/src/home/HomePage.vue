<template>
  <div class="startGame">
    <button @click="startGame">
    Start Game
  </button>
  </div>

</template>

<script>
import { onBeforeRouteLeave, useRouter } from 'vue-router';
import getQuestion from '../shared/getQuestion';
import { useGameInfoStore } from '../store/index';

export default {
  name: 'HomePage',
  setup() {
    useGameInfoStore().reset();

    const router = useRouter();

    let canLeave = false;
    function leave() { canLeave = true; }
    const promise = getQuestion();
    promise.then(() => { leave(); });

    const startGame = () => {
      promise.then(() => { router.push('/game'); });
    };

    onBeforeRouteLeave((to) => {
      if (to.path === '/game') {
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
