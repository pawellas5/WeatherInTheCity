<template>
    <div class="navBtn" v-if="isLoading">
        <LogoutButton />
  </div>
    <div class="navBtn" v-else>
      <template v-if="!isAuthenticated">
        <div class="authenticatedBtns">
        <LoginButton />
        <SignupButton />
    </div>
      </template>
      <template v-if="isAuthenticated">
        <!-- {{ user.name }} -->

        <LogoutButton />
      </template>
    </div>
  </template>

<script setup>
import { useAuth0 } from '@auth0/auth0-vue';
import LoginButton from './LoginButton.vue';
import LogoutButton from './LogoutButton.vue';
import SignupButton from './SignupButon.vue';

const { isAuthenticated } = useAuth0();
const { isLoading } = useAuth0();

// const auth0 = useAuth0();

// const user = auth0 ? auth0.user : null;
</script>

<style scoped>

.navBtn{
    height: 100%;
    width: 80%;
}
.authBtn{
    cursor: pointer;
    font-size: 1.5rem;
}
.authenticatedBtns{
    height: 100%;
    display:flex;
    flex-direction: row;
    align-items:center;
    justify-content: space-evenly;

}

</style>
