<template>
    <div  class="navBtn" v-if="isLoading">

  </div>
    <div class="navBtn" v-else>
      <template v-if="!isAuthenticated">
        <div class="authenticatedBtns">
        <LoginButton />
        <SignupButton />
    </div>
      </template>
      <template v-if="isAuthenticated">
          <div class="dropdownContainer">
  <button @click="toggleUserMenu" class="dropdownBtn">
    {{user.name}}
  </button>
  <div  v-if="isUserMenuVisible" class="dropdownItems">
    <!-- eslint-disable-next-line vuejs-accessibility/click-events-have-key-events -->
    <RouterLink @click="toggleUserMenu" to="/profile">Details</RouterLink>
    <LogoutButton  @click="toggleUserMenu"/>
  </div>
</div>
      </template>
    </div>
  </template>

<script setup>
import { ref } from 'vue';
import { useAuth0 } from '@auth0/auth0-vue';
import LoginButton from './LoginButton.vue';
import LogoutButton from './LogoutButton.vue';
import SignupButton from './SignupButon.vue';

const isUserMenuVisible = ref(false);

const { isAuthenticated } = useAuth0();
const { isLoading } = useAuth0();

const auth0 = useAuth0();

const user = auth0 ? auth0.user : null;
function toggleUserMenu() {
  isUserMenuVisible.value = !(isUserMenuVisible.value);
}

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

.dropdownBtn {
  background-color:#1d1f20;
  color: white;
  padding: 16px;
  font-size: 1.5rem;
  border: none;
  cursor: pointer;
  border-radius:1rem;
}
.dropdownContainer {
  position: relative;
  display: inline-block;
}

.dropdownItems {
  position: absolute;
  background-color: #1d1f20;
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
  border-bottom-right-radius: 1rem;
  border-bottom-left-radius: 1rem;

}
.dropdownItems a {
  color: white;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
  font-size:1rem;

}
.dropdownItems :last-child{
  border-bottom-right-radius: 1rem;
  border-bottom-left-radius: 1rem;
}
.dropdownItems a:hover {background-color: rgb(53, 55, 59);}

</style>
