<template>
  <div id="app">
    <notifications group="toasts" />
    <div id="header">
      <nav-bar-component />
    </div>
    <div id="body" v-if="$route.path == '/'">
      <pagina-principal />
    </div>
    <div class="container-fluid main-page">
      <router-view />
    </div>
    <div id="footer" class="fixed-bottom">
      <footer-component />
    </div>
  </div>
</template>

<script>
// import HelloWorld from './components/HelloWorld.vue'
import NavBarComponent from "./components/NavBar.vue";
import FooterComponent from "./components/Footer.vue";
import PaginaPrincipal from "./components/PaginaPrincipal.vue";

export default {
  name: "App",
  components: {
    // HelloWorld
    NavBarComponent,
    FooterComponent,
    PaginaPrincipal,
  },
};
</script>

<style></style>
