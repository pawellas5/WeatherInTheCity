<!-- eslint-disable vuejs-accessibility/click-events-have-key-events -->
<template>
    <a class="authBtn" @click="handleSignUp">Sign Up</a>
  </template>

<script setup>
import { useAuth0 } from '@auth0/auth0-vue';

const { loginWithRedirect } = useAuth0();

const handleSignUp = () => {
  loginWithRedirect({
    appState: {
      target: '/',
    },
    authorizationParams: {
      screen_hint: 'signup',
    },
  });
};
</script>
