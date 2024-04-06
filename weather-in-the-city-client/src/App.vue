<template>
  <nav>
    <ul>
      <li class="logo">
        <router-link v-if="!isAuthenticated" class="link" to="/">WeatherInTheCity</router-link>
        <router-link v-if="isAuthenticated" class="link" to="/start">WeatherInTheCity</router-link>
        <img  src="./assets/weather_logo.png" alt="logo">
      </li>
      <li class="space">

      </li>
      <li class="navBtns">
        <!-- signup, login, logout -->
        <NavbarButtons/>
      </li>
    </ul>
  </nav>
  <div class="content">
    <router-view></router-view>
  </div>
  <footer>
    <a href="https://www.iconfinder.com/">
      https://www.iconfinder.com/
    </a>
  </footer>
</template>

<script>
import { useAuth0 } from '@auth0/auth0-vue';
import NavbarButtons from './authentication/buttons/NavbarButtons.vue';

export default {
  name: 'App',
  components: {
    NavbarButtons,
  },

  setup() {
    const { isAuthenticated } = useAuth0();

    return {
      isAuthenticated,
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
.navBtns{
  width:300px;

}
.space{
  flex-grow: 1;
}

.logo{
  display:flex;
  width:300px;

}
.logo .link{
  text-decoration: none;
  color:inherit;
}

nav{

  height:5rem;
  background-color: rgb(53, 55, 59);
  color:white;
  font-size: 2rem;

}
nav ul{
  display:flex;
  height:100%;
  padding:1rem 20rem 1rem 20rem;
  justify-content: left;
  gap: 5rem;

}
nav ul li{
  list-style: none;
}
footer{
  display: flex;
  justify-content: center;
  align-content: center;
  height:5rem;
  background-color: rgb(53, 55, 59);
}
footer a{

  color:rgba(255, 255, 255,0.100);
  text-decoration:none;
  padding:1.5rem 0 1rem 0;
  font-size: 1.5rem;

}
footer a:hover{
  color:white;

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
   nav ul{

    padding:1rem 18rem 1rem 18rem;

   }
  }

@media screen and (max-width: 1536px ){
  .content{
  padding: 0rem 10rem 0rem 10rem;
  }
  nav ul{

  padding:1rem 10rem 1rem 10rem;

  }
}

@media screen and (max-width: 1366px ){
   .content{
    padding: 0rem 5rem 0rem 5rem;
   }
   nav ul{

    padding:1rem 5rem 1rem 5rem;

   }
}

@media screen and (max-width: 1024px ){
   .content{
    padding: 0rem 0rem 0rem 0rem;
   }
   nav ul{

    padding:1rem 0rem 1rem 0rem;
    justify-content:center;

   }
}

@media screen and (max-width: 1024px ) and (orientation:landscape){
  footer a{
    font-size: 1.2rem;
   }
}

@media screen and (max-width: 932px ) and (orientation: landscape){
  nav{
    height: 3rem;
  }
  nav ul{
    padding:0.3rem 25rem 0.3rem 25rem;
  }
  footer{
    height: 3rem;
  }
  footer a{
    font-size: 0.8rem;
    padding:1rem 0 1rem 0;

   }
}

@media screen and (max-width: 740px ) and (orientation: landscape){
  footer a{
    font-size: 0.6rem;
   }
}

@media screen and (max-width: 540px ){
   .content{
    padding: 0rem 0rem 0rem 0rem;
   }
   nav ul{

    padding:1rem 0rem 1rem 0rem;
    justify-content:center;

   }
   footer a{
    font-size: 1.2rem;
   }
}

@media screen and (max-width: 375px ){
   footer a{
    font-size: 1.1rem;
   }
}

@media screen and (max-width: 280px ){
   nav ul{
    padding: 1.5rem;
    font-size: 1.5rem;
   }
   nav ul li img{
    width:40px;
    height:40px;
   }
   footer a{
    font-size: 0.9rem;
   }
}

</style>
