import { defineStore } from 'pinia';
import axios from 'axios';

export const useGameDataStore = defineStore(
  'gameData',
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

export const useGameInfoStore = defineStore(
  'gameInfo',
  {
    state: () => ({

      questionNumber: 1,
      points: 0,
      questionTotal: 10,

    }),
    actions: {
      addPoint() {
        this.points += 1;
      },
      nextQuestion() {
        this.questionNumber += 1;
      },
      reset() {
        this.points = 0;
        this.questionNumber = 1;
      },
    },

  },
);
