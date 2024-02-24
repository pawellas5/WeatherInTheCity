<template>
  <nav>
    <ul>
      <li class="logo">
        <a href="/">WeatherInTheCity</a>
        <img  src="./assets/weather_logo.png" alt="logo">
      </li>
    </ul>
  </nav>
  <div class="content">
    <HomePage/>

  </div>
  <footer>
    <a href="https://www.iconfinder.com/">
      https://www.iconfinder.com/
    </a>
  </footer>
</template>

<script>
import HomePage from './home/HomePage.vue';

export default {
  name: 'App',
  components: {
    HomePage,
  },
};
</script>

<style>
*{
  margin:0;
  padding:0;
  box-sizing: border-box;
}
.logo{
  display:flex;
  width:300px;

}
.logo a{
  text-decoration: none;
  color:inherit;
}
.logo img{
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
  padding:1rem 25rem 1rem 25rem;
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
a:hover{
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
  padding:0rem 25rem 0rem 25rem;
  /* marginesy z lewej i prawej dla glownego contentu */

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
</style>
