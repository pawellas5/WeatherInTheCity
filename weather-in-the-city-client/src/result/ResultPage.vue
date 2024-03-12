<template>
    <div class="result">
        Your score is {{ points }} out of {{ questionTotal }}.
    </div>

  </template>

<script>
import { useGameInfoStore } from '../store/index';

export default {
  name: 'ResultPage',

  setup() {
    const gameInfoStore = useGameInfoStore();
    const { points, questionTotal } = gameInfoStore;
    gameInfoStore.reset();

    return {
      points,
      questionTotal,
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
