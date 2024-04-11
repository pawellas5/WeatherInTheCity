<!-- eslint-disable vuejs-accessibility/click-events-have-key-events -->
<template>
  <nav>
    <div class="navDiv">
        <button class = "homeButton">
        <router-link v-if="!isAuthenticated" class=" logo link" to="/">
          <img class="logoImage" src="./assets/rainbow_logo.png" alt="logo">
          <span class="pageTitle">WeatherInTheCity</span>
        </router-link>
        <router-link v-if="isAuthenticated" class=" logo link" to="/start">
          <img class="logoImage" src="./assets/rainbow_logo.png" alt="logo">
          <span class="pageTitle">WeatherInTheCity</span></router-link>
        </button>
      <div class="space"></div>
      <div class="navBtns">
          <!-- signup, login, logout -->
          <NavbarButtons/>

      </div>

    </div>
  </nav>
  <div class="content">
    <router-view></router-view>
  </div>
  <footer>
    <div class="footerRowSpace"></div>
    <div class="footerItems">
      <div class="footerItem">Copyright 2024 WeatherInTheCity PB</div>
      <div class="footerColSpace"></div>
    <div class="footerItem"><a href="https://www.iconfinder.com/">
      https://www.iconfinder.com/
    </a></div>
    </div>
    <div class="footerRowSpace"></div>

  </footer>
</template>

<script>
import { useAuth0 } from '@auth0/auth0-vue';
import NavbarButtons from './authentication/buttons/NavbarButtons.vue';
import LoginButton from './authentication/buttons/LoginButton.vue';
import SignupButton from './authentication/buttons/SignupButon.vue';

export default {
  name: 'App',
  components: {
    NavbarButtons,
  },

  setup() {
    const { isAuthenticated } = useAuth0();

    return {
      isAuthenticated,
      LoginButton,
      SignupButton,
    };
  },

};

</script>

<style>
*{
  margin:0;
  padding:0;
  box-sizing: border-box;
}
.homeButton{
  border-radius: 1rem;
  color:inherit;
  background-color: #1d1f20;
  border:none;
  /* border-color:rgba(255, 0, 0, 0.247); */
  /* font-size:1.5rem; */
  padding:0.5rem 0 0.5rem 0;
  font-size:inherit;

}

.logoImage{
  width:15%;
}

.navBtns{
  width:300px;
  height: 100%;

}
.footerRowSpace{
  flex-grow:1;
}
.footerColSpace{
  flex-grow:1
}

.logo{
  display:flex;
  width:300px;
  height:100%;
  gap:0.5rem;
}
.link{
  text-decoration: none;
  color:inherit;
  display:flex;
  justify-content: center;
  align-items: center;
}

nav{
  display:flex;
  /* height:5rem; */
  background-color: rgb(53, 55, 59);
  color:white;
  font-size: 2rem;
  width:100%;
  height:104px;

}
.navDiv{
  display:flex;
  height:100%;
  padding:1rem 20rem 1rem 20rem;
  justify-content: left;
  /* gap: 5rem; */
  width:100%;
  font-size:1.5rem;

}

.space{
  flex-grow:1;
}

.footerItems{

  display: flex;
  flex-direction: column;
  color:white;
  width:100%;
  height:70%;
}

.footerItem{
height:50%;
display:flex;
align-items: center;
justify-content: center;
font-size:1.2rem;
color:rgba(255, 255, 255,0.100);

}

footer{
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-content: center;
  height:5rem;
  background-color: rgb(53, 55, 59);
}
footer a{

  color:rgba(255, 255, 255,0.100);
  text-decoration:none;
  /* padding:1.5rem 0 1rem 0; */
  /* font-size: 1rem; */

}

.content{
  color: #2c3e50;
  display:flex;
  gap:2.5rem;
  justify-content: center;
  align-content: top;
  align-items: top;
  background-color: #233, 234, 237;
  flex-grow:1;
  padding:0rem 20rem 0rem 20rem;
  /* main horizontal margins */

  border-top: 20px solid #1d1f20;
  border-bottom: 20px solid #1d1f20;

}

#app {
  font-family: 'Roboto', sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  display: flex;
  flex-direction: column;
  height: 100vh;

}

@media screen and (max-width: 1920px ){
  .content{
    padding: 0rem 18rem 0rem 18rem;
  }
  nav .navDiv{

    padding:1rem 18rem 1rem 18rem;

  }
}

@media screen and (max-width: 1536px ){
  .content{
    padding: 0rem 10rem 0rem 10rem;
  }
  nav .navDiv{
    padding:1rem 10rem 1rem 10rem;
  }
}
@media screen and (max-width: 1366px ){
  .content{
    padding: 0rem 5rem 0rem 5rem;
  }
  nav .navDiv{
    padding:1rem 5rem 1rem 5rem;
  }
}

@media screen and (max-width: 1024px ){
  .content{
    padding: 0rem 0rem 0rem 0rem;
  }
  nav .navDiv{
    padding:1rem 0rem 1rem 0rem;
    justify-content:center;
  }
}

@media screen and (max-width: 1024px ) and (orientation:landscape){
  footer a{
    font-size: 1.2rem;
  }
  .navDiv{
    gap:0;
  }
  .homeButton{
    margin-left: 24px;
  }
}

@media screen and (max-width: 932px ) and (orientation: landscape){
  nav{
    height: 80px;
    justify-content: center;
    align-items: center;
  }
  nav .navDiv{
    padding:0.3rem 4rem 0.3rem 4rem;
  }
  .navDiv{
    height:85%;
  }
  footer a{
    font-size: 0.8rem;
    padding:1rem 0 1rem 0;
  }
}

@media screen and (max-width: 740px ) and (orientation: landscape){

  .navDiv{
    font-size:1.3rem;
  }

  .pageTitle{
    display:none;
  }

  .logo{
    width:80px;
  }

  .navBtns{
    width:200px;
  }

  .logoImage{
    width:55px;
  }

  .homeButton{
    border-radius: 1rem;
    color:inherit;
    background-color: #1d1f20;
    border:none;
    padding:1rem 0 1rem 0;
    font-size:inherit;
  }

  .footerColSpace{
    flex-grow:0;
  }

  .footerRowSpace{
    flex-grow:0;
  }

  .footerItem{
    height:100%;
    font-size:1rem;
    width:50%;
  }

  footer a{
    font-size: 1rem;
  }

  .footerItems{
  flex-direction: row;
  }

}

@media screen and (max-width: 1024px ){
  .homeButton{
    margin-left: 35px;
  }
}
@media screen and (max-width: 768px ){
  .navBtns{
    margin-right:35px;
  }
}
@media screen and (max-width: 540px ){
  .content{
    padding: 0rem 0rem 0rem 0rem;
  }

  footer a{
    font-size: 1.2rem;
  }

  .space{
    flex-grow:1;
  }

  .navDiv{
    font-size: 1.3rem;
    padding:1rem 0rem 1rem 0rem;
    gap:0;
  }

  .pageTitle{
    display:none;
  }

  .logo{
    width:80px;
  }
  .navBtns{
    width:200px;
  }
  .logoImage{
    width:55px;
  }

  .homeButton{
    border-radius: 1rem;
    color:inherit;
    background-color: #1d1f20;
    border:none;
    padding:1rem 0 1rem 0;
    font-size:inherit;
    margin-left: 24px;
  }
}

@media screen and (max-width: 375px ){
   footer a{
    font-size: 1.1rem;
   }
}

@media screen and (max-width: 320px ){
   nav .navDiv{
    padding: 1.5rem;
    font-size: 1.5rem;
   }
   nav .navDiv .logo img{
    width:40px;
    height:40px;
   }

   .footerItem{
    font-size: 1rem;
   }

   .footerItem a{
    font-size: 0.8rem;
   }
   .homeButton{
    margin-left:0;
   }
   .navBtns{
    width:80px;
    margin-right:0px;
   }

}

@media screen and (max-width: 320px ){
   .footerItem{
    font-size: 0.9rem;
   }
}

</style>
