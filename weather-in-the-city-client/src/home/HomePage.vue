<template>
  <div class="startGame">
    <button @click="startGame">
    Start Game
  </button>
  </div>

</template>

<script>
import { useRouter } from 'vue-router';

export default {
  name: 'HomePage',
  setup() {
    const router = useRouter();
    return {
      startGame: () => router.push('/game'),
    };
  },
};
</script>

<style scoped>

.startGame{

  width:100%;
  height:100%;
  display:flex;
  justify-content: center;
  align-items: center;

}
.startGame button{

    width:250px;
    height:100px;
    border-radius: 2rem;
    border:0;
    background-color: #ff7900;
    color:white;
    font-size: 2rem;
}
.startGame button:hover{
  cursor:pointer;
  background-color:#ff9300;

}
  </style>
