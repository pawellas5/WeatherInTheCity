<template>
    <div class="result">
        Your score is {{ result }}%.
    </div>

  </template>

<script>
import { useGameInfoStore } from '../store/index';

export default {
  name: 'ResultPage',

  setup() {
    const gameInfoStore = useGameInfoStore();
    const { points, questionTotal } = gameInfoStore;
    const result = (points / questionTotal) * 100;
    gameInfoStore.reset();

    return {
      result,
    };
  },

};

</script>

  <style scoped>

  .result{

    width:100%;
    height:100%;
    display:flex;
    justify-content: center;
    align-items: center;
    background-color: #ff7900;
    font-size: 2rem;
    color:white;

  }

    </style>
