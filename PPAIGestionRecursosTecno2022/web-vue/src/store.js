import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    logged_in: false,
    usuario: "",
    recTecnologicos: [],
  },
  mutations: {
    iniciarSesion(state, usuario) {
      state.logged_in = true;
      state.usuario = usuario;
    },
    cerrarSesion(state) {
      state.logged_in = false;
      state.usuario = "";
    },
    agregarRecTecnologico(state, recTecnologico) {
      state.recTecnologicos = recTecnologico;
    },
    falseLoggedIn(state) {
      state.logged_in = false;
    },
    vaciarRecTecnologicos(state) {
      state.recTecnologicos = [];
    }
  },
  actions: {
    iniciarSesion({ commit }, usuario) {
      commit("iniciarSesion", usuario);
    },
    cerrarSesion({ commit }) {
      commit("iniciarSesion");
    },
    agregarRecTecnologico({ commit }, recTecnologico) {
      commit("agregarRecTecnologico", recTecnologico);
    },
    falseLoggedIn({ commit }) {
      commit("falseLoggedIn");
    },
    vaciarRecTecnologicos({ commit }) {
      commit("vaciarRecTecnologicos");
    }
  },
  getters: {
    logged_in(state) {
      return state.logged_in;
    },
    usuario(state) {
      return state.usuario;
    },
    recTecnologicos(state) {
      return state.recTecnologicos;
    }
  },
});
