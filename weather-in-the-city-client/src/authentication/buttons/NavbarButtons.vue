<template>

    <div  class="navBtn" v-if="isLoading">
  </div>
    <div class="navBtn" v-else>
      <template v-if="!isAuthenticated">
        <div class="authenticatedBtns">
          <div class="userDiv">
          <div class="lowResolution">
            <LoginLowResolution/>
          </div>
          <div class="highResolution">
              <LoginButton />
              <SignupButton />
          </div>
          </div>
        </div>
      </template>
      <template v-if="isAuthenticated">

          <div class="dropdownContainer">
            <div class="userDiv">
            <button @click="toggleUserMenu" class="dropdownBtn">
    <img class="userIcon" src="../../assets/user_icon_2.png" alt="LogIn">
    <!-- {{user.name}} -->
  </button>
</div>
  <div  v-if="isUserMenuVisible" class="dropdownItems">
    <!-- eslint-disable-next-line vuejs-accessibility/click-events-have-key-events -->
    <div class = "nickName">
      {{ user.nickname }}</div>
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
import LoginLowResolution from './LoginLowResolution.vue';

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

.userDiv{
  text-align:center;
  height: 100%;
}
.iconSpace{
  flex-grow:1;
}
.lowResolution{
  height:100%;
  display:none;
}
.highResolution{
  height: 100%;
  display:flex;
  flex-direction: row;
  align-items:center;
  justify-content: space-evenly;
}

.nickName{
  border-bottom: 1px solid white ;
  padding-bottom: 1rem;
  padding-top: 1rem;
}
.userIcon{
  width:50px;
}

.navBtn{
    height: 100%;
    width: 100%;

}
.authBtn{
    cursor: pointer;
    font-size: inherit;
}
.authenticatedBtns{
  height:100%;
}

.dropdownBtn {
  background-color:#1d1f20;
  color: white;
  padding: 0.5rem;
  font-size: inherit;
  border: none;
  cursor: pointer;
  border-radius:1rem;

}
.dropdownContainer {

  width:100%;
  position: relative;
  display: block;
}

.dropdownItems {
  position: absolute;
  background-color: #1d1f20;
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
  border-bottom-right-radius: 1rem;
  border-bottom-left-radius: 1rem;
  font-size:1.5rem;
  text-align: center;
  width:100%;
  margin-top:35px;
  /* padding:1rem 0 1rem 0; */

}
.dropdownItems a {
  color: white;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
  font-size:1rem;
  padding:1rem 0 1rem 0;

}
.dropdownItems :last-child{
  border-bottom-right-radius: 1rem;
  border-bottom-left-radius: 1rem;
}
.dropdownItems a:hover {background-color: rgb(53, 55, 59);}

@media screen and (max-width: 768px ){
  .userDiv{
  height:100%;
  display:flex;
  justify-content: end;
}

  .highResolution{
    display:none;
  }
  .lowResolution{
    display:block;
  }
  .userIcon{
    width:51px;
  }
  .dropdownItems{
    min-width:80px;
  }
  .nickName{
    display: none;
  }
  .dropdownBtn{
    width:80px;
  }

}

@media screen and (max-width: 280px ){

  .userIcon{
    width:34px;
  }
  .dropdownBtn{
    width:70px;
  }

}

</style>
