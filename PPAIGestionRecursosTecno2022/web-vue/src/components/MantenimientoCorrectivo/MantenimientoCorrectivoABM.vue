<template>
  <div class="container-fluid my-3">
    <div class="formulario">
      <div class="form-row">
        <div class="col">
          <div class="form-group">
            <span class="tituloDatos">Fin previsto del mantenimiento:</span>
            <input type="date" v-model="modelo.finPrevisto" />
          </div>
        </div>
      </div>
      <div class="form-row">
        <div class="col">
          <div class="form-group">
            <span class="tituloDatos">Razón del mantenimiento:</span>
            <input type="text" style="width: 18rem" v-model="modelo.razon" />
          </div>
        </div>
      </div>
      <div class="form-row">
        <div class="col">
          <div class="form-group" style="text-align: end">
            <button
              id="btnBuscarReservas"
              class="btn btn-primary"
              @click="buscarReservas"
            >
              Buscar reservas
            </button>
          </div>
        </div>
      </div>
      <div class="form-row">
        <div class="col">
          <div id="tablaReservas" class="form-group">
            <h4>Se muestran las reservas</h4>
          </div>
        </div>
      </div>
      <div class="form-row buttons">
        <div class="col">
          <div class="form-group">
            <button id="btnGuardar" class="btn btn-primary" @click="guardar">
              Guardar
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "MantenimientoCorrectivoABM",
  data() {
    return {
      modelo: {
        finPrevisto: null,
        razon: null,
      },
    };
  },
  methods: {
    guardar() {
      console.log("Se guarda: ", this.modelo);
    },
    buscarReservas() {
      console.log("Se buscan las reservas");
    },
  },
};
</script>

<style>
.tituloDatos {
  margin-right: 1%;
}

.form-row {
  margin-top: 1%;
}

#btnGuardar {
  margin-right: 1%;
}

.buttons {
  text-align: right;
}
</style>
