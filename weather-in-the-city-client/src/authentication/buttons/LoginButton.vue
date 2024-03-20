<!-- eslint-disable vuejs-accessibility/click-events-have-key-events -->
<template>
    <a class = "authBtn" @click="handleLogin">Log In</a>
  </template>

<script setup>
import { useAuth0 } from '@auth0/auth0-vue';

const { loginWithRedirect } = useAuth0();

const handleLogin = () => {
  loginWithRedirect({
    appState: {
      target: '/',
    },
  });
};
</script>
