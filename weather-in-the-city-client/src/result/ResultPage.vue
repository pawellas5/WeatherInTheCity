<template>
    <div class="result">

      <div class="resultBox">
        <img v-show="positiveResult" class="emoji"
        src="../assets/positiveResult.png" alt="positive" >
      <img v-show="!positiveResult" class="emoji"
      src="../assets/negativeResult.png" alt="negative" >
        <div class="resultTitle positiveResult" v-if="positiveResult">You won</div>
        <div class="resultTitle negativeResult" v-else>You lost</div>
       <div class="score">Your score is {{ percentageResult+"%" }}</div>
      </div>
    </div>

  </template>

<script>
import { storeToRefs } from 'pinia';
import { computed } from 'vue';
import { useGameDataStore } from '../store/index';

export default {
  name: 'ResultPage',

  setup() {
    const gameDataStore = useGameDataStore();
    const { percentageResult } = storeToRefs(gameDataStore);
    const positiveResult = computed(() => percentageResult.value >= 50);
    return {
      percentageResult,
      positiveResult,
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
    font-size: 2rem;
    color:white;
    flex-direction: column;

  }
  .resultBox{
    display:flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    border-radius: 2rem;
    width:70%;
    height:90%;
    background-color:rgb(53, 55, 59);
    border: 5px solid #1d1f20;

  }
  .resultTitle{
    font-size: 8rem;
  }
  .positiveResult{
    color:green;
  }
  .negativeResult{
    color:red;
  }
  .emoji{
    width: 40%;
  }

    </style>
