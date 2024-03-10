<template>
    <div class="result">
        Your score is {{ points }} out of {{ totalPoints }}.
    </div>

  </template>

<script>
import { useRoute } from 'vue-router';

export default {
  name: 'ResultPage',
  setup() {
    const route = useRoute();
    const { points, totalPoints } = route.params;

    return {
      points,
      totalPoints,
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
