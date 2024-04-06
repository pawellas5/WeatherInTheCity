<template>
    <div class="homeDiv">
        <div class="homeBtns">
            <button @click="playDemo" class="homeBtn">
                Demo
            </button>
            <button  @click="handleLogin" class="homeBtn">
                Full version
            </button>
            </div>
    </div>

  </template>

<script>
import { onBeforeRouteLeave, useRouter } from 'vue-router';
import { useAuth0 } from '@auth0/auth0-vue';
import { useGameInfoStore, useGameDataStore } from '../store/index';

window.addEventListener('beforeunload', async () => {
  await useGameDataStore().removeCurrentGame(useGameDataStore().gameFlowId);
});

export default {
  name: 'HomePage',
  setup() {
    const { loginWithRedirect } = useAuth0();
    const router = useRouter();

    const handleLogin = () => {
      loginWithRedirect({
        appState: {
          target: '/start',
        },
      });
    };

    useGameInfoStore().reset();
    const gameDataStore = useGameDataStore();
    onBeforeRouteLeave(async (to) => {
      if (to.path === '/game' || to.path === '/profile' || to.path === '/start') {
        if (to.path !== '/game') await gameDataStore.removeCurrentGame(gameDataStore.gameFlowId);
        return true;
      }
      return false;
    });

    function playDemo() {
      router.push({
        name: 'Start',
      });
    }
    return {
      handleLogin,
      playDemo,
    };
  },
  beforeRouteEnter() {
    if (useAuth0().isAuthenticated.value === true) {
      return '/start';
    }
    return true;
  },

};

</script>

  <style scoped>

  .homeDiv{

    width:100%;
    height:100%;
    display:flex;
    justify-content: center;
    align-items: center;

  }

  .homeBtns{
    width:80%;
    height:25%;
    display: flex;
    flex-direction: column;
    justify-content: space-evenly;
    align-items: center;
  }

  .homeBtn{

      width:250px;
      height:100px;
      border-radius: 2rem;
      border:0;
      background-color: #ff7900;
      color:white;
      font-size: 2rem;
  }
  .homeBtn:hover{
    cursor:pointer;
    background-color:#ff9300;
  }

    </style>
