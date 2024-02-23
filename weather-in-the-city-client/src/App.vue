<template>
  <HomePage/>
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
#app {
  font-family: 'Roboto', sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  height: 100vh;
  display:flex;
  flex-direction: column;
  gap:2.5rem;
  justify-content: center;
  align-content: center;
  align-items: center;
  background-color: #dde3c7;
}
</style>
