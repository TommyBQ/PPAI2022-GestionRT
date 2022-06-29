<template>
  <div id="mantenimientoCorrectivo">
    <div class="noLogueado" v-if="!this.$store.getters.logged_in">
      <h1>No se inició sesión. Por favor, inicie sesión.</h1>
    </div>
    <div class="mantCorrLogueado" v-if="this.$store.getters.logged_in">
      <h1>Mantenimiento Correctivo</h1>
      <div id="tableRecTec">
        <table class="table table-striped">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Nombre</th>
              <th scope="col">Tipo de Recurso</th>
              <th scope="col">Marca</th>
              <th scope="col">Modelo</th>
              <th scope="col">Estado</th>
              <th scope="col">Acciones</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="(rec, index) in recursosTecnologicos" :key="index">
              <th scope="row">{{ rec.id }}</th>
              <td>{{ rec.nombre }}</td>
              <td>{{ rec.tipo }}</td>
              <td>{{ rec.marca }}</td>
              <td>{{ rec.modelo }}</td>
              <td>
                <span class="badge bg-success">{{ rec.estado }}</span>
              </td>
              <td>
                <button
                  class="btn btn-primary"
                  @click="seleccionarRecurso(rec)"
                >
                  Seleccionar
                </button>
                <button
                  class="btn btn-secondary"
                  style="margin-left: 1rem"
                  @click="verTurnos(rec)"
                >
                  Ver Turnos
                </button>
              </td>
            </tr>
          </tbody>
        </table>
      </div>

      <b-modal
        hide-footer
        id="RecursoTecnoModal"
        size="lg"
        @hidden="buscar"
        title="Registrar Recurso Técnologico a Mantenimiento Correctivo"
      >
        <MantenimientoCorrectivoABM
          @closeModal="$bvModal.hide('RecursoTecnoModal')"
        />
      </b-modal>      
      
      <b-modal
        hide-footer
        id="TurnosModal"
        size="lg"
        :title="tituloModal"
      >
        <Turnos
          @closeModal="$bvModal.hide('TurnosModal')" :turnos="recursosTecnologicos"
        />
      </b-modal>
    </div>
  </div>
</template>

<script>
import MantenimientoCorrectivoABM from "./MantenimientoCorrectivoABM.vue";
import Turnos from '../Turnos.vue';

export default {
  name: "MantenimientoCorrectivo",
  components: {
    MantenimientoCorrectivoABM,
    Turnos,
  },
  data() {
    return {
      recursosTecnologicos: [],
      turnos: [],
      tituloModal: ""
    };
  },
  mounted() {
    this.recursosTecnologicos = this.$store.getters.recTecnologicos;
  },
  methods: {
    seleccionarRecurso(rec) {
      var app = this;
      console.log(rec);
      app.$bvModal.show("RecursoTecnoModal");
    },
    verTurnos(rec) {
      var app = this;
      console.log(rec.turnos);
      this.turnos = rec.turnos;
      this.tituloModal = "Turnos del Recurso Técnologico - " + rec.nombre;
      app.$bvModal.show("TurnosModal");
    },
    buscar() {
      console.log(
        "Despues de que se cierra el modal, se buscan los recursos. Actualizandose la lista."
      );
    },
  },
};
</script>

<style>
#tableRecTec {
  margin-left: 1%;
  margin-right: 1%;
}

.modal-backdrop {
  opacity: 60% !important;
}
</style>
