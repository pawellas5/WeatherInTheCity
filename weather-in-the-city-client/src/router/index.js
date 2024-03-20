import { createRouter, createWebHashHistory } from 'vue-router';
// import { authGuard } from '@auth0/auth0-vue';
import HomePage from '../home/HomePage.vue';
import GamePage from '../game/GamePage.vue';
import ResultPage from '../result/ResultPage.vue';
import CallbackPage from '../authentication/callback/CallbackPage.vue';

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
        if (from.name === undefined) return { name: 'Home' };// on page refresh, go home
        return true;
      },
      // beforeEnter: authGuard,

    },
    {
      name: 'Result',
      path: '/result',
      component: ResultPage,
      beforeEnter: (to, from) => {
        if (from.name === 'Home' || from.name === undefined) return { name: 'Home' };
        return true;
      },

    },

    {
      path: '/callback',
      name: 'callback',
      component: CallbackPage,
    },
  ],
  history: createWebHashHistory(),
});
