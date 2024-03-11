import { createRouter, createWebHashHistory } from 'vue-router';
import HomePage from '../home/HomePage.vue';
import GamePage from '../game/GamePage.vue';
import ResultPage from '../result/ResultPage.vue';

export default createRouter({
  routes: [
    {
      name: 'Home',
      path: '/',
      component: HomePage,
    },
    {
      name: 'Game',
      path: '/game',
      component: GamePage,
      beforeEnter: (to, from) => {
        console.log(from.name);
        if (from.name === undefined) return { name: 'Home' };// on page refresh, go home
        return true;
      },

    },
    {
      name: 'Result',
      path: '/result/:points/:totalPoints',
      component: ResultPage,

    },
  ],
  history: createWebHashHistory(),
});
