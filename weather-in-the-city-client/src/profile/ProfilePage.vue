<template >
    <div class="userContainer">

        <div class="userDetails">
            <div class="detailsRow">
                <div class="rowTitle">User:</div>
                <div class="rowValue">{{ user.name }}</div>
            </div>
            <div class="detailsRow">
                <div class="rowTitle">Wins:</div>
                <div class="rowValue">{{userStats.wins??0 }}</div>
            </div>
            <div class="detailsRow">
                <div class="rowTitle">Defeats:</div>
                <div class="rowValue">{{userStats.defeats??0 }}</div>
            </div>
            <div class="detailsRow">
                <div class="rowTitle">Games:</div>
                <div class="rowValue">{{ userStats.games??0 }}</div>
            </div>

        </div>

    </div>

  </template>

<script>
import { useAuth0 } from '@auth0/auth0-vue';
import { storeToRefs } from 'pinia';
import { useGameDataStore } from '../store/index';

export default {

  name: 'ProfilePage',

  setup() {
    const auth0 = useAuth0();
    const user = auth0 ? auth0.user : null;

    const gameDataStore = useGameDataStore();
    const { userStats } = storeToRefs(gameDataStore);

    const { getAccessTokenSilently } = useAuth0();
    const getUserStats = async () => {
      const accessToken = await getAccessTokenSilently();
      await gameDataStore.getUserStats(accessToken);
    };

    getUserStats();

    return {
      user,
      userStats,
    };
  },

  beforeRouteEnter() {
    if (useAuth0().isAuthenticated.value === true) {
      return true;
    }
    // eslint-disable-next-line no-alert
    alert('You have to be logged in to access this page.');
    return false;
  },

};

</script>

  <style scoped>

  .userContainer{

    width:100%;
    height:100%;
    display:flex;
    justify-content: center;
    align-items: center;
    font-size: 2rem;
    color:white;

  }
  .userDetails{
    width:70%;
    height:70%;
    display:flex;
    justify-content: center;
    align-items: center;
    background-color:rgb(53, 55, 59);
    font-size: 2rem;
    border-radius:2rem;
    border:5px solid #1d1f20;
    flex-direction: column;
    text-align: left;
    gap:5%
  }
  .detailsRow{
    width:50%;
    border-bottom:5px solid #1d1f20;
    display: flex;

  }
  .rowValue{
    width:70%;
    color:#ff7900;
    font-style: italic;
    text-align: center;
  }
    .rowTitle{
        width:30%;
        font-style: italic;
    }

    </style>
