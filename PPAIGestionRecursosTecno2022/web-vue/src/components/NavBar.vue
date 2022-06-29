<template>
  <div id="navBar">
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
      <div class="container-fluid">
        <router-link class="navbar-brand" to="/">PPAI 2022</router-link>
        <button
          class="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarTogglerDemo02"
          aria-controls="navbarTogglerDemo02"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarTogglerDemo02">
          <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li>
              <router-link class="nav-link" to="/HelloWorld"
                >HelloWorld</router-link
              >
            </li>
            <li class="nav-item dropdown">
              <a
                class="nav-link dropdown-toggle"
                href="#"
                id="navbarScrollingDropdown"
                role="button"
                data-bs-toggle="dropdown"
                aria-expanded="false"
              >
                Mantenimiento Correctivo
              </a>
              <ul
                class="dropdown-menu"
                aria-labelledby="navbarScrollingDropdown"
              >
                <li>
                  <router-link
                    class="dropdown-item"
                    to="/MantenimientoCorrectivo"
                    >Registrar RT</router-link
                  >
                </li>
              </ul>
            </li>
          </ul>
          <form class="d-flex">
            <div
              class="iniciarSesion"
              style="padding-left: 1%"
              v-if="!this.$store.state.logged_in"
            >
              <button class="btn btn-outline-success btn-lg" type="button">
                <router-link to="/InicioSesion"
                  ><i class="bi bi-person"></i
                ></router-link>
              </button>
            </div>
            <div class="cerrarSesion" v-if="this.$store.state.logged_in">
              <div class="dropstart">
                <button
                  class="btn btn-outline-success dropdown-toggle btn-lg"
                  type="button"
                  id="dropdownMenuButton1"
                  data-bs-toggle="dropdown"
                  aria-expanded="false"
                  style="margin-left: 3%"
                >
                  <i class="bi bi-person" style="margin-right: 3%"
                    ><span>{{ this.$store.getters.usuario }}</span></i
                  >
                </button>
                <ul class="dropdown-menu" aria-labelledby="dropdownMenuButton1">
                  <li><a class="dropdown-item" href="#">Mi usuario</a></li>
                  <li>
                    <a class="dropdown-item" @click="cerrarSesion()"
                      >Cerrar sesión</a
                    >
                  </li>
                </ul>
              </div>
            </div>
          </form>
        </div>
      </div>
    </nav>
  </div>
</template>

<script>
export default {
  name: "NavBarComponent",
  components: {
    // HelloWorld
  },
  methods: {
    cerrarSesion() {
      this.$store.dispatch("cerrarSesion");
      this.$store.commit("falseLoggedIn");
      this.$store.commit("vaciarRecTecnologicos");
      this.$router.push("/InicioSesion");
    },
  },
};
</script>

<style></style>
