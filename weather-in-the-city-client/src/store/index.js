import { defineStore } from 'pinia';
import axios from 'axios';

export default defineStore(
  'gameStore',
  {
    state: () => ({
      gameData: '',
    }),
    getters: {
      weather: (state) => state.gameData.weather,
      cities: (state) => state.gameData.cities,
    },
    actions:
    {
      getGameData() {
        return axios.get('https://localhost:7172/game/')
          .then((response) => { this.gameData = response.data; })
          .catch((error) => { console.log(error); });
      },
    },
  },
);
