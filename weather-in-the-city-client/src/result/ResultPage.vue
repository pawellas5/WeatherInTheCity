<template>
    <div class="result">
        Your score is {{ percentageResult }}.
    </div>

  </template>

<script>
import { storeToRefs } from 'pinia';
import { useGameDataStore } from '../store/index';

export default {
  name: 'ResultPage',

  setup() {
    const gameDataStore = useGameDataStore();
    const { percentageResult } = storeToRefs(gameDataStore);
    return {
      percentageResult,
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
