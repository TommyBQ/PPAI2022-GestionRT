<template>
  <div class="tablaTurnos">
    <table class="table table-striped">
      <thead>
        <tr>
          <th scope="col">#</th>
          <th scope="col">Fecha Inicio</th>
          <th scope="col">Hora Inicio</th>
          <th scope="col">Fecha Fin</th>
          <th scope="col">Hora Fin</th>
          <th scope="col">Día de la semana</th>
          <th scope="col">Estado</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(t, index) in rec.turnos" :key="index">
          <th scope="row">{{ t.id }}</th>
          <td>{{ t.fechaHoraInicio.substring(0,9) }}</td>
          <td>{{ t.fechaHoraInicio.substring(9,14) }}</td>
          <td>{{ t.fechaHoraFin.substring(0,9) }}</td>
          <td>{{ t.fechaHoraFin.substring(9,14) }}</td>
          <td>{{ t.diaSemana }}</td>
          <td>
            <span class="badge bg-success">{{ t.estado }}</span>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
export default {
  name: "TurnosABM",
  props: {
    rec: {
      type: Array,
    },
  },
};
</script>

<style></style>
