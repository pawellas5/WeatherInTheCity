<!-- eslint-disable vuejs-accessibility/click-events-have-key-events -->
<template>
    <button class = "lowResBtn" @click="handleLogin">
        <img class="lowResImg" src="../../assets/lock.png" alt="logo">
    </button>
  </template>

<script setup>
import { useAuth0 } from '@auth0/auth0-vue';

const { loginWithRedirect } = useAuth0();

const handleLogin = () => {
  loginWithRedirect({
    appState: {
      target: '/start',
    },
  });
};
</script>

<style scoped>

.lowResBtn{
  background-color:#1d1f20;
  color: white;
  padding: 0.5rem;
  font-size: inherit;
  border: none;
  cursor: pointer;
  border-radius:1rem;
  width:80px;
  height: 100%;
}

.lowResImg{
  width:35px;
}
</style>
