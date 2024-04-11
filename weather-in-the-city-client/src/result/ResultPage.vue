<template>
    <div class="result">

      <div class="resultBox">
        <img v-show="positiveResult" class="emoji"
        src="../assets/positiveResult.png" alt="positive" >
        <img v-show="!positiveResult" class="emoji"
        src="../assets/negativeResult.png" alt="negative" >
        <div class="resultTitle positiveResult" v-show="positiveResult">You won</div>
        <div class="resultTitle negativeResult" v-show="!positiveResult">You lost</div>
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

  @media screen and (max-width: 1536px ) and (orientation: landscape){

  .resultBox{
    width:70%;
    height:70%;
  }
  .result{
    font-size: 1.5rem;
  }
  .resultTitle{
    font-size: 5rem;
  }

  .emoji{
    width: 25%;
  }

}

@media screen and (max-width: 1080px ){
  .resultBox{
    width:90%;
    height:40%;
  }
  .emoji{
    width: 60%;
  }
}
@media screen and (max-width: 1024px ){

  .resultBox{
    width:70%;
    height:70%;
  }
  .result{
    font-size: 1.5rem;
  }
  .resultTitle{
    font-size: 5rem;
  }
  .emoji{
    width: 50%;
  }

}

@media screen and (max-width: 1024px ) and (orientation: landscape){

  .resultBox{
    height:80%;
  }
  .resultTitle{
    font-size: 4.5rem;
  }
  .emoji{
    width: 20%;
  }
}

@media screen and (max-width: 430px ){

  .resultBox{
    height:50%;
  }
  .resultTitle{
    font-size: 3rem;
  }

  .result{
    font-size: 1.1rem;
  }

  .emoji{
    width: 65%;
  }

}

@media screen and (max-width: 375px ){

  .resultBox{
    height:70%;
    width:75%;
  }

}

@media screen and (max-width: 280px ){

  .resultBox{
    height:65%;
    width:80%;
  }
  .emoji{
    width: 80%;
  }

  .result{
    font-size: 1rem;
  }

}

    </style>
