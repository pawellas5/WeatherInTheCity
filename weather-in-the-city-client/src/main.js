import { createApp } from 'vue';
import { createPinia } from 'pinia';
import { createAuth0 } from '@auth0/auth0-vue';
import App from './App.vue';
import router from './router/index';

createApp(App)
  .use(router)
  .use(createPinia())
  .use(
    createAuth0({
      domain: process.env.VUE_APP_AUTH0_DOMAIN,
      clientId: process.env.VUE_APP_AUTH0_CLIENT_ID,
      authorizationParams: {
        redirect_uri: process.env.VUE_APP_AUTH0_CALLBACK_URL,
      },
    }),
  )
  .mount('#app');
