<!-- eslint-disable vuejs-accessibility/click-events-have-key-events -->
<template>
    <a class="authBtn" @click="handleLogout">Log Out</a>
  </template>

<script setup>
import { useAuth0 } from '@auth0/auth0-vue';

const { logout } = useAuth0();

const handleLogout = () => logout({
  logoutParams: {
    returnTo: window.location.origin,
  },
});
</script>
