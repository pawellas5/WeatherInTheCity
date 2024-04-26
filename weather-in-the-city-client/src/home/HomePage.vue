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
      if (to.path === '/game' || to.path === '/profile' || to.path === '/start' || to.path === '/attribution') {
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
    gap:1.5rem;
  }

  .homeBtn{

      width:16rem;
      height:6rem;
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

  @media screen and (max-width: 1920px ){

    .homeBtns{
      height:35%;
    }

}

@media screen and (max-width: 1366px )and (orientation:landscape){

.homeBtns{
  height:45%;
}

}

@media screen and (max-width: 1280px )and (orientation:landscape){

.homeBtns{
  height:50%;
}

}
@media screen and (max-width: 1024px ){

  .homeBtns{
    height:25%;
  }

}

@media screen and (max-width: 1024px ) and (orientation:landscape){
  .homeBtns{
    height:60%;
  }
}

@media screen and (max-width: 853px ){

  .homeBtns{
    height:28%;
  }

}

@media screen and (max-width: 768px ){

  .homeBtns{
    height:35%;
  }

}

@media screen and (max-width: 800px ) and (orientation:landscape){

  .homeBtns{
    height:70%;
  }

}

@media screen and (max-width: 540px ){

  .homeBtns{
    height:55%;
  }

}

@media screen and (max-width: 430px ){

  .homeBtns{
    height:35%;
  }

  .homeBtn{
    height:90px;
    font-size: 1.9rem;
  }

}
@media screen and (max-width:390px){

  .homeBtn{
    width:200px;
    height:70px;
    font-size: 1.8rem;
  }
  .homeBtns{
    height:30%;
  }
}

@media screen and (max-width:375px){

  .homeBtns{
    height:45%;
  }
}

@media screen and (max-width:360px){
  .homeBtns{
    height:35%;
  }
  .homeBtn{
    font-size: 1.6rem;
  }
}

@media screen and (max-width:280px){
  .homeBtns{
    height:42%;
  }

  .homeBtn{
    width:180px;
    height:65px;
    font-size: 1.5rem;
  }
}

</style>
