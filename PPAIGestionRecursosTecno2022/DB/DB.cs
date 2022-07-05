using Microsoft.EntityFrameworkCore;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.DB
{
    public class DB : DbContext
    {
        public void cargarDatos()
        {
            //Usuarios
            List<Usuario> allUsuarios = new List<Usuario>();
            Usuario usuario1 = new Usuario(1, "1234", "admin", true);
            Usuario usuario2 = new Usuario(2, "1234jp", "juanPerez", true);
            Usuario usuario3 = new Usuario(3, "1234tom", "tommyB", true);
            Usuario usuario4 = new Usuario(5, "1234doe", "bobRuts", true);
            Usuario usuario5 = new Usuario(6, "1234zuck", "bobRuts", true);

            allUsuarios.Add(usuario1);
            allUsuarios.Add(usuario2);
            allUsuarios.Add(usuario3);
            allUsuarios.Add(usuario4);
            allUsuarios.Add(usuario5);

            //PersonalCientifico
            List<PersonalCientifico> allPersonalCientificos = new List<PersonalCientifico>();
            PersonalCientifico personalCientifico1 = new PersonalCientifico("11133","Admin","Istrador","01010101","admin@gmail.com","elmejoradmin@gmail.com","3513513513",usuario1);
            PersonalCientifico personalCientifico2 = new PersonalCientifico("48789","Juan","Perez","42587896","juanPerez@gmail.com","jp@gmail.com","3514879585",usuario2);
            PersonalCientifico personalCientifico3 = new PersonalCientifico("78561","Tommy","Barrera","4228062","tommybarrera@gmail.com","tomB@gmail.com","3513842060",usuario3);
            PersonalCientifico personalCientifico4 = new PersonalCientifico("14578","John","Doe","14478596","johndoe@gmail.com","johndough@gmail.com","3514878988",usuario4);
            PersonalCientifico personalCientifico5 = new PersonalCientifico("12345","Mark","Zuckerberg","42598666","markz@gmail.com","mark666@gmail.com","351487489",usuario5);

            allPersonalCientificos.Add(personalCientifico1);
            allPersonalCientificos.Add(personalCientifico2);
            allPersonalCientificos.Add(personalCientifico3);
            allPersonalCientificos.Add(personalCientifico4);
            allPersonalCientificos.Add(personalCientifico5);

            //Sesion
            List<Sesion> allSesiones = new List<Sesion>();
            Sesion sesion1 = new Sesion("Descripcion de sesión.", usuario1);
            Sesion sesion2 = new Sesion("Descripcion de sesión.", usuario2);
            Sesion sesion3 = new Sesion("Descripcion de sesión.", usuario3);
            Sesion sesion4 = new Sesion("Descripcion de sesión.", usuario4);
            Sesion sesion5 = new Sesion("Descripcion de sesión.", usuario5);

            allSesiones.Add(sesion1);
            allSesiones.Add(sesion2);
            allSesiones.Add(sesion3);
            allSesiones.Add(sesion4);
            allSesiones.Add(sesion5);

            //TipoRT
            List<TipoRT> allTipoRTs = new List<TipoRT>();
            TipoRT tipoRT1 = new TipoRT("TipoRT1", "DescripcionRT1");
            TipoRT tipoRT2 = new TipoRT("TipoRT2", "DescripcionRT2");
            TipoRT tipoRT3 = new TipoRT("TipoRT3", "DescripcionRT3");
            TipoRT tipoRT4 = new TipoRT("TipoRT4", "DescripcionRT4");
            TipoRT tipoRT5 = new TipoRT("TipoRT5", "DescripcionRT5");

            allTipoRTs.Add(tipoRT1);
            allTipoRTs.Add(tipoRT2);
            allTipoRTs.Add(tipoRT3);
            allTipoRTs.Add(tipoRT4);
            allTipoRTs.Add(tipoRT5);

            //Modelo
            List<Modelo> allModelos = new List<Modelo>();
            Modelo modelo1 = new Modelo("Modelo1");
            Modelo modelo2 = new Modelo("Modelo2");
            Modelo modelo3 = new Modelo("Modelo3");
            Modelo modelo4 = new Modelo("Modelo4");
            Modelo modelo5 = new Modelo("Modelo5");

            allModelos.Add(modelo1);
            allModelos.Add(modelo2);
            allModelos.Add(modelo3);
            allModelos.Add(modelo4);
            allModelos.Add(modelo5);

            //Marca
            List<Marca> allMarcas = new List<Marca>();
            Marca marca1 = new Marca("Marca1");
            Marca marca2 = new Marca("Marca2");
            Marca marca3 = new Marca("Marca3");
            Marca marca4 = new Marca("Marca4");
            Marca marca5 = new Marca("Marca5");

            marca1.agregarModelo(modelo1);
            marca1.agregarModelo(modelo2);

            marca2.agregarModelo(modelo3);
            marca2.agregarModelo(modelo4);

            marca3.agregarModelo(modelo5);
            marca3.agregarModelo(modelo2);

            marca4.agregarModelo(modelo3);
            marca4.agregarModelo(modelo1);

            marca5.agregarModelo(modelo4);
            marca5.agregarModelo(modelo3);

            allMarcas.Add(marca1);
            allMarcas.Add(marca2);
            allMarcas.Add(marca3);
            allMarcas.Add(marca4);
            allMarcas.Add(marca5);

            //Mantenimiento
            List<Mantenimiento> allMantenimientos = new List<Mantenimiento>();

            //Estado
            List<Estado> allEstados = new List<Estado>();
            Estado estado1 = new Estado(1, "Disponible", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado2 = new Estado(2, "Ingresado", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado3 = new Estado(3, "Cancelado por mantenimiento preventivo", "Descripcion1", "Turno", true, true);
            Estado estado4 = new Estado(4, "Cancelado por mantenimiento correctivo", "Descripcion1", "Turno", true, true);
            Estado estado5 = new Estado(5, "Ingreso a mantenimiento preventivo", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado6 = new Estado(6, "Ingreso a mantenimiento preventivo", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado7 = new Estado(7, "Con reserva confirmada", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado8 = new Estado(8, "Pendiente de confirmacion de reserva", "Descripcion1", "RecursoTecnologico", true, true);

            allEstados.Add(estado1);    
            allEstados.Add(estado2);
            allEstados.Add(estado3);
            allEstados.Add(estado4);
            allEstados.Add(estado5);
            allEstados.Add(estado6);
            allEstados.Add(estado7);
            allEstados.Add(estado8);

            //CambioEstadoTurno
            List<CambioEstadoTurno> allCambiosEstadoTurnos = new List<CambioEstadoTurno>();
            CambioEstadoTurno cambioEstadoTurno1 = new CambioEstadoTurno(DateTime.Now, null, estado3);
            CambioEstadoTurno cambioEstadoTurno2 = new CambioEstadoTurno(DateTime.Now, null, estado4);

            allCambiosEstadoTurnos.Add(cambioEstadoTurno1);
            allCambiosEstadoTurnos.Add(cambioEstadoTurno2);

            //CambioEstadoRT
            List<CambioEstadoRT> allCambioEstadoRTs = new List<CambioEstadoRT>();
            CambioEstadoRT cambioEstadoRT1 = new CambioEstadoRT(1, DateTime.Now, null, estado1);
            CambioEstadoRT cambioEstadoRT2 = new CambioEstadoRT(2, DateTime.Now, null, estado2);
            CambioEstadoRT cambioEstadoRT3 = new CambioEstadoRT(3, DateTime.Now, null, estado5);
            CambioEstadoRT cambioEstadoRT4 = new CambioEstadoRT(4, DateTime.Now, null, estado6);
            CambioEstadoRT cambioEstadoRT5 = new CambioEstadoRT(5, DateTime.Now, null, estado7);
            CambioEstadoRT cambioEstadoRT6 = new CambioEstadoRT(6, DateTime.Now, null, estado8);

            allCambioEstadoRTs.Add(cambioEstadoRT1);
            allCambioEstadoRTs.Add(cambioEstadoRT2);
            allCambioEstadoRTs.Add(cambioEstadoRT3);
            allCambioEstadoRTs.Add(cambioEstadoRT4);
            allCambioEstadoRTs.Add(cambioEstadoRT5);
            allCambioEstadoRTs.Add(cambioEstadoRT6);

            //Turnos
            List<Turno> allTurnos = new List<Turno>();
            Turno turno1 = new Turno(DateTime.Now.AddDays(2).AddHours(2), DateTime.Now.AddDays(2).AddHours(4), DateTime.Now.AddDays(2).DayOfWeek.ToString(), DateTime.Now);
            Turno turno2 = new Turno(DateTime.Now.AddDays(3).AddHours(2), DateTime.Now.AddDays(3).AddHours(4), DateTime.Now.AddDays(3).DayOfWeek.ToString(), DateTime.Now);
            Turno turno3 = new Turno(DateTime.Now.AddDays(2).AddHours(4), DateTime.Now.AddDays(2).AddHours(6), DateTime.Now.AddDays(2).DayOfWeek.ToString(), DateTime.Now);
            Turno turno4 = new Turno(DateTime.Now.AddDays(5).AddHours(1), DateTime.Now.AddDays(5).AddHours(3), DateTime.Now.AddDays(5).DayOfWeek.ToString(), DateTime.Now);
            Turno turno5 = new Turno(DateTime.Now.AddDays(12).AddHours(6), DateTime.Now.AddDays(12).AddHours(7), DateTime.Now.AddDays(12).DayOfWeek.ToString(), DateTime.Now);

            turno1.AgregarCambioEstadoTurno(cambioEstadoTurno1);
            turno2.AgregarCambioEstadoTurno(cambioEstadoTurno2);
            turno3.AgregarCambioEstadoTurno(cambioEstadoTurno1);

            allTurnos.Add(turno1);
            allTurnos.Add(turno2);
            allTurnos.Add(turno3);
            allTurnos.Add(turno4);
            allTurnos.Add(turno5);

            //RecursoTecnologico
            List<RecursoTecnologico> allRecursosTecnologicos = new List<RecursoTecnologico>();
            RecursoTecnologico recursoTecnologico1 = new RecursoTecnologico(1, "RT1", modelo1, tipoRT1, null, null, null);
        }
    }
}