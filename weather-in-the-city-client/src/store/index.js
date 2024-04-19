import { defineStore } from 'pinia';
import axios from 'axios';

export const useGameDataStore = defineStore(
  'gameData',
  {
    state: () => ({
      gameData: '',
      guessResult: '',
      percentageResult: '',
      userStats: '',
    }),
    getters: {
      weather: (state) => state.gameData.weather,
      cities: (state) => state.gameData.cities,
      gameFlowId: (state) => state.gameData.gameFlowId,

      isUserCorrect: (state) => state.guessResult.isUserCorrect,
      userAnswer: (state) => state.guessResult.userAnswer,
      correctAnswer: (state) => state.guessResult.correctAnswer,

    },
    actions:
    {
      getGameData(gameId = null) {
        return axios.get(`${process.env.VUE_APP_API_URL}/game/`, {
          headers: {
            gameFlowId: gameId,
          },
        })
          .then((response) => { this.gameData = response.data; })
          .catch((error) => { console.log(error); });
      },

      postAnswer(questionNumber, city, gameId) {
        return axios({
          method: 'post',
          url: `${process.env.VUE_APP_API_URL}/game/check`,
          data: {
            QuestionNumber: questionNumber,
            City: city,
          },
          headers: {
            gameFlowId: gameId,
          },

        })
          .then((response) => { this.guessResult = response.data; })
          .catch((error) => { console.log(error); });
      },

      getPercentageResult(gameId) {
        return axios({
          method: 'get',
          url: `${process.env.VUE_APP_API_URL}/game/result`,
          headers: {
            gameFlowId: gameId,
          },
        })
          .then((response) => { this.percentageResult = response.data; })
          .catch((error) => { console.log(error); });
      },

      removeCurrentGame(gameId) {
        return axios.delete(`${process.env.VUE_APP_API_URL}/game/gameflow/`, {
          headers: {
            gameFlowId: gameId,
          },
        })
          .catch((error) => console.log(error));
      },
      addUserStats(accessToken, gameId) {
        return axios({
          method: 'put',
          url: `${process.env.VUE_APP_API_URL}/user/stats`,
          headers: {
            Authorization: `Bearer ${accessToken}`,
            gameFlowId: gameId,
          },

        })
          .catch((error) => {
            console.log(error);
          });
      },

      getUserStats(accessToken) {
        return axios({
          method: 'get',
          url: `${process.env.VUE_APP_API_URL}/user/stats`,
          headers: {
            Authorization: `Bearer ${accessToken}`,
          },

        })
          .then((response) => {
            this.userStats = response.data;
          })
          .catch((error) => {
            console.log(error);
          });
      },
    },
  },
);

export const useGameInfoStore = defineStore(
  'gameInfo',
  {
    state: () => ({

      questionNumber: 1,
      questionTotal: 10,

    }),
    actions: {
      nextQuestion() {
        this.questionNumber += 1;
      },
      reset() {
        this.questionNumber = 1;
      },
    },

  },

);
