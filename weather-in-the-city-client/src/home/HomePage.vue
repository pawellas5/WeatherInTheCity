<template>
    <div class="main">
      {{ cities }}
    </div>
    <button class="btn" @click="getGameData">
      Click
    </button>
  </template>

<script>
import { storeToRefs } from 'pinia';
import useGameStore from '../store/index';

export default {
  name: 'HomePage',
  methods: {
    getGameData() {
      this.store.getGameData();
    },
  },
  setup() {
    const store = useGameStore();
    const { weather, cities } = storeToRefs(store);
    return {
      store,
      weather,
      cities,
    };
  },
};
</script>

  <style scoped>

  .main{
    width:2000px;
    height: 400px;
    background-color: rgb(9, 36, 70);
    border:4px solid white;
    border-radius: 2rem;
    color:white;
    font-size:2rem;
    text-align:left;
    padding:1.5rem;
  }
  .btn{
    width:200px;
    height:200px;
    border:4px solid  white;
    border-radius:50%;
    background-color: rgb(129, 51, 51);
    color:white;
    font-size: 4rem;;
    font-weight: bold;
  }
  .btn:hover{
    background-color: rgba(129, 51, 51, 0.800);
    cursor: pointer;
  }

  h3 {
    margin: 40px 0 0;
  }
  ul {
    list-style-type: none;
    padding: 0;
  }
  li {
    display: inline-block;
    margin: 0 10px;
  }
  a {
    color: #42b983;
  }
  </style>
