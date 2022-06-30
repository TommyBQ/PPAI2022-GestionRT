<template>
  <div id="inicio-sesion">
    <div class="card" style="margin-top: -5%; margin-bottom: 10%">
      <div class="card-body">
        <div class="row">
          <h1 id="titulo-inicio-sesion">Inicie Sesión</h1>
          <div class="col">
            <div class="input-group mb-3">
              <span class="input-group-text" id="basic-addon1">@</span>
              <input
                type="text"
                class="form-control"
                placeholder="Ingrese usuario.."
                aria-label="Ingrese nombre.."
                aria-describedby="basic-addon1"
                v-model="usuario"
              />
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col">
            <div class="input-group mb-3">
              <span class="input-group-text" id="basic-addon3">Contraseña</span>
              <input
                type="password"
                class="form-control"
                placeholder="Ingrese constraseña.."
                aria-label="Ingrese nombre.."
                aria-describedby="basic-addon3"
                v-model="contrasena"
              />
            </div>
          </div>
        </div>
        <div class="row" style="text-align: right">
          <div class="col">
            <button
              type="button"
              class="btn btn-primary"
              style="margin-right: 1%"
              @click="iniciarSesion(usuario, contrasena)"
            >
              Iniciar Sesión
            </button>
            <button type="button" class="btn btn-primary" @click="registrar()">
              Registrarse
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "IniciarSesion",
  data() {
    return {
      usuario: "",
      contrasena: "",
      usuarios: [
        {
          nombre: "Admin",
          apellido: "instrador",
          usuario: "admin",
          contrasena: "1234",
          id: "1",
          recTecnologicos: [
            {
              id: 1,
              nombre: "Recurso 1 ADMIN",
              descripcion: "Descripcion del recurso 1 ADMIN",
              tipo: "Tipo 1",
              numero: "Numero 1",
              marca: "Marca 1",
              modelo: "Modelo 1",
              responsable: "ADMIN",
              estado: "Disponible",
              turnos: [
                {
                  id: 1,
                  fechaHoraInicio: "2020-05-01 10:00:00",
                  fechaHoraFin: "2020-05-01 12:00:00",
                  diaSemana: "Miércoles",
                  estado: "Confirmado",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 12:00:00",
                  fechaHoraFin: "2020-01-01 13:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-09-22 16:00:00",
                  fechaHoraFin: "2020-09-22 17:30:00",
                  diaSemana: "Martes",
                  estado: "Pendiente",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 15:00:00",
                  fechaHoraFin: "2020-01-01 16:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
              ],
            },
            {
              id: 2,
              nombre: "Recurso 2 ADMIN",
              descripcion: "Descripcion del recurso 2 ADMIN",
              tipo: "Tipo 2",
              numero: "Numero 2",
              marca: "Marca 2",
              modelo: "Modelo 2",
              responsable: "ADMIN",
              estado: "Disponible",
              turnos: [
                {
                  id: 1,
                  fechaHoraInicio: "2020-05-01 10:00:00",
                  fechaHoraFin: "2020-05-01 12:00:00",
                  diaSemana: "Miércoles",
                  estado: "Confirmado",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 12:00:00",
                  fechaHoraFin: "2020-01-01 13:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-09-22 16:00:00",
                  fechaHoraFin: "2020-09-22 17:30:00",
                  diaSemana: "Martes",
                  estado: "Pendiente",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 15:00:00",
                  fechaHoraFin: "2020-01-01 16:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
              ],
            },
            {
              id: 3,
              nombre: "Recurso 3 ADMIN",
              descripcion: "Descripcion del recurso 3 ADMIN",
              tipo: "Tipo 3",
              numero: "Numero 3",
              marca: "Marca 3",
              modelo: "Modelo 3",
              responsable: "ADMIN",
              estado: "Disponible",
              turnos: [
                {
                  id: 1,
                  fechaHoraInicio: "2020-05-01 10:00:00",
                  fechaHoraFin: "2020-05-01 12:00:00",
                  diaSemana: "Miércoles",
                  estado: "Confirmado",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 12:00:00",
                  fechaHoraFin: "2020-01-01 13:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-09-22 16:00:00",
                  fechaHoraFin: "2020-09-22 17:30:00",
                  diaSemana: "Martes",
                  estado: "Pendiente",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 15:00:00",
                  fechaHoraFin: "2020-01-01 16:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
              ],
            },
          ],
        },
        {
          nombre: "Juan",
          apellido: "Perez",
          usuario: "juanPerez",
          contrasena: "1234jp",
          id: "2",
          recTecnologicos: [
            {
              id: 1,
              nombre: "Recurso 1 juanPerez",
              descripcion: "Descripcion del recurso 1 juanPerez",
              tipo: "Tipo 1",
              numero: "Numero 1",
              marca: "Marca 1",
              modelo: "Modelo 1",
              responsable: "juanPerez",
              estado: "Disponible",
              turnos: [
                {
                  id: 1,
                  fechaHoraInicio: "2020-05-01 10:00:00",
                  fechaHoraFin: "2020-05-01 12:00:00",
                  diaSemana: "Miércoles",
                  estado: "Confirmado",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 12:00:00",
                  fechaHoraFin: "2020-01-01 13:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-09-22 16:00:00",
                  fechaHoraFin: "2020-09-22 17:30:00",
                  diaSemana: "Martes",
                  estado: "Pendiente",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 15:00:00",
                  fechaHoraFin: "2020-01-01 16:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
              ],
            },
            {
              id: 2,
              nombre: "Recurso 2 juanPerez",
              descripcion: "Descripcion del recurso 2 juanPerez",
              tipo: "Tipo 2",
              numero: "Numero 2",
              marca: "Marca 2",
              modelo: "Modelo 2",
              responsable: "juanPerez",
              estado: "Disponible",
              turnos: [
                {
                  id: 1,
                  fechaHoraInicio: "2020-05-01 10:00:00",
                  fechaHoraFin: "2020-05-01 12:00:00",
                  diaSemana: "Miércoles",
                  estado: "Confirmado",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 12:00:00",
                  fechaHoraFin: "2020-01-01 13:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-09-22 16:00:00",
                  fechaHoraFin: "2020-09-22 17:30:00",
                  diaSemana: "Martes",
                  estado: "Pendiente",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 15:00:00",
                  fechaHoraFin: "2020-01-01 16:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
              ],
            },
            {
              id: 3,
              nombre: "Recurso 3 juanPerez",
              descripcion: "Descripcion del recurso 3 juanPerez",
              tipo: "Tipo 3",
              numero: "Numero 3",
              marca: "Marca 3",
              modelo: "Modelo 3",
              responsable: "juanPerez",
              estado: "Disponible",
              turnos: [
                {
                  id: 1,
                  fechaHoraInicio: "2020-05-01 10:00:00",
                  fechaHoraFin: "2020-05-01 12:00:00",
                  diaSemana: "Miércoles",
                  estado: "Confirmado",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 12:00:00",
                  fechaHoraFin: "2020-01-01 13:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-09-22 16:00:00",
                  fechaHoraFin: "2020-09-22 17:30:00",
                  diaSemana: "Martes",
                  estado: "Pendiente",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 15:00:00",
                  fechaHoraFin: "2020-01-01 16:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
              ],
            },
          ],
        },
        {
          nombre: "Solo",
          apellido: "Lectura",
          usuario: "soloLectura",
          contrasena: "readonly",
          id: "3",
          recTecnologicos: [
            {
              id: 1,
              nombre: "Recurso 1 soloLectura",
              descripcion: "Descripcion del recurso 1 soloLectura",
              tipo: "Tipo 1",
              numero: "Numero 1",
              marca: "Marca 1",
              modelo: "Modelo 1",
              responsable: "soloLectura",
              estado: "Disponible",
              turnos: [
                {
                  id: 1,
                  fechaHoraInicio: "2020-05-01 10:00:00",
                  fechaHoraFin: "2020-05-01 12:00:00",
                  diaSemana: "Miércoles",
                  estado: "Confirmado",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 12:00:00",
                  fechaHoraFin: "2020-01-01 13:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-09-22 16:00:00",
                  fechaHoraFin: "2020-09-22 17:30:00",
                  diaSemana: "Martes",
                  estado: "Pendiente",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 15:00:00",
                  fechaHoraFin: "2020-01-01 16:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
              ],
            },
            {
              id: 2,
              nombre: "Recurso 2 soloLectura",
              descripcion: "Descripcion del recurso 2 soloLectura",
              tipo: "Tipo 2",
              numero: "Numero 2",
              marca: "Marca 2",
              modelo: "Modelo 2",
              responsable: "soloLectura",
              estado: "Disponible",
              turnos: [
                {
                  id: 1,
                  fechaHoraInicio: "2020-05-01 10:00:00",
                  fechaHoraFin: "2020-05-01 12:00:00",
                  diaSemana: "Miércoles",
                  estado: "Confirmado",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 12:00:00",
                  fechaHoraFin: "2020-01-01 13:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-09-22 16:00:00",
                  fechaHoraFin: "2020-09-22 17:30:00",
                  diaSemana: "Martes",
                  estado: "Pendiente",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 15:00:00",
                  fechaHoraFin: "2020-01-01 16:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
              ],
            },
            {
              id: 3,
              nombre: "Recurso 3 soloLectura",
              descripcion: "Descripcion del recurso 3 soloLectura",
              tipo: "Tipo 3",
              numero: "Numero 3",
              marca: "Marca 3",
              modelo: "Modelo 3",
              responsable: "soloLectura",
              estado: "Disponible",
              turnos: [
                {
                  id: 1,
                  fechaHoraInicio: "2020-05-01 10:00:00",
                  fechaHoraFin: "2020-05-01 12:00:00",
                  diaSemana: "Miércoles",
                  estado: "Confirmado",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 12:00:00",
                  fechaHoraFin: "2020-01-01 13:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-09-22 16:00:00",
                  fechaHoraFin: "2020-09-22 17:30:00",
                  diaSemana: "Martes",
                  estado: "Pendiente",
                },
                {
                  id: 1,
                  fechaHoraInicio: "2020-01-01 15:00:00",
                  fechaHoraFin: "2020-01-01 16:00:00",
                  diaSemana: "Lunes",
                  estado: "A Confirmar",
                },
              ],
            },
          ],
        },
      ],
    };
  },
  methods: {
    iniciarSesion(user, psswd) {
      axios
        .get(
          "api/MantenimientoRT/IniciarSesion?usuario=" +
            user +
            "+&clave=" +
            psswd
        )
        .then((response) => {
          console.log(response.data);
          if (response.data != null) {
            this.$store.dispatch("iniciarSesion", response.data.usuario.nombreUsuario);
            this.$router.push("/");
            this.$notify({
              group: "toasts",
              title: "Inicio de sesión",
              type: "success",
              text: "Se inició sesión correctamente!! :D",
            });
          } else {
            alert("Usuario o contraseña incorrectos");
          }
        }).catch((error) => {
          this.$notify({
              group: "toasts",
              title: "Inicio de sesión",
              type: "error",
              text: error.response.data,
            });
        });
    },
    registrar() {
      axios
        .get(
          "api/MantenimientoRT/RegistrarUsuario?usuario=" +
            this.usuario +
            "+&clave=" +
            this.contrasena
        )
        .then((response) => {
          this.$store.dispatch("iniciarSesion", this.usuario);
          this.$notify({
            group: "toasts",
            title: "Registro de usuario",
            type: "success",
            text: response.data,
          });
          this.$router.push("/");
        });
    },
  },
};
</script>

<style>
#inicio-sesion {
  margin-top: 5%;
  margin-left: 35%;
  margin-right: 35%;
}

#titulo-inicio-sesion {
  font-size: 2.5em;
  font-weight: bold;
  text-align: center;
}
</style>
