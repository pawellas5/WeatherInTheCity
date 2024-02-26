import { createRouter, createWebHashHistory } from 'vue-router';
import HomePage from '../home/HomePage.vue';
import GamePage from '../game/GamePage.vue';

export default createRouter({
  routes: [
    {
      path: '/',
      component: HomePage,
    },
    {
      path: '/game',
      component: GamePage,
    },
  ],
  history: createWebHashHistory(),
});
