import Vue from 'vue'
import App from './App.vue'
import store from '@/store'

import router from './router'
import VueSax from "vuesax";
import "bootstrap";
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-icons/font/bootstrap-icons.css'
import { ModalPlugin} from 'bootstrap-vue';
import Notifications from 'vue-notification'

Vue.use(Notifications)
Vue.use(VueSax);
Vue.use(ModalPlugin)

Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App),
}).$mount('#app')
