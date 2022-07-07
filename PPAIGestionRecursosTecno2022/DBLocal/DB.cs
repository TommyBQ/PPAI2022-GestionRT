using Microsoft.EntityFrameworkCore;
using PPAIGestionRecursosTecno2022.Models;
using PPAIGestionRecursosTecno2022.Services;

namespace PPAIGestionRecursosTecno2022.DB
{
    public class DB : DbContext
    {
        private static DB _db;

        public static DB Instance
        {
            get
            {
                if (_db == null) _db = new DB();
                return _db;
            }
        }

        public void cargarDatos()
        {
            //Usuarios
            Usuario usuario1 = new Usuario(1, "1234", "admin", true);
            Usuario usuario2 = new Usuario(2, "1234jp", "juanPerez", true);
            Usuario usuario3 = new Usuario(3, "1234tom", "tommyB", true);
            Usuario usuario4 = new Usuario(5, "1234doe", "bobRuts", true);
            Usuario usuario5 = new Usuario(6, "1234zuck", "bobRuts", true);

            UsuarioService.GetInstance.Insert(usuario1);
            UsuarioService.GetInstance.Insert(usuario2);
            UsuarioService.GetInstance.Insert(usuario3);
            UsuarioService.GetInstance.Insert(usuario4);
            UsuarioService.GetInstance.Insert(usuario5);

            //PersonalCientifico
            PersonalCientifico personalCientifico1 = new PersonalCientifico("11133", "Admin", "Istrador", "01010101", "admin@gmail.com", "elmejoradmin@gmail.com", "3513513513", usuario1);
            PersonalCientifico personalCientifico2 = new PersonalCientifico("48789", "Juan", "Perez", "42587896", "juanPerez@gmail.com", "jp@gmail.com", "3514879585", usuario2);
            PersonalCientifico personalCientifico3 = new PersonalCientifico("78561", "Tommy", "Barrera", "4228062", "tommybarrera@gmail.com", "tomB@gmail.com", "3513842060", usuario3);
            PersonalCientifico personalCientifico4 = new PersonalCientifico("14578", "John", "Doe", "14478596", "johndoe@gmail.com", "johndough@gmail.com", "3514878988", usuario4);
            PersonalCientifico personalCientifico5 = new PersonalCientifico("12345", "Mark", "Zuckerberg", "42598666", "markz@gmail.com", "mark666@gmail.com", "351487489", usuario5);

            PersonalCientificoService.GetInstance.Insert(personalCientifico1);
            PersonalCientificoService.GetInstance.Insert(personalCientifico2);
            PersonalCientificoService.GetInstance.Insert(personalCientifico3);
            PersonalCientificoService.GetInstance.Insert(personalCientifico4);
            PersonalCientificoService.GetInstance.Insert(personalCientifico5);

            //Sesion
            Sesion sesion1 = new Sesion("Descripcion de sesión.", usuario1);
            Sesion sesion2 = new Sesion("Descripcion de sesión.", usuario2);
            Sesion sesion3 = new Sesion("Descripcion de sesión.", usuario3);
            Sesion sesion4 = new Sesion("Descripcion de sesión.", usuario4);
            Sesion sesion5 = new Sesion("Descripcion de sesión.", usuario5);

            SesionService.GetInstance.Insert(sesion1);
            SesionService.GetInstance.Insert(sesion2);
            SesionService.GetInstance.Insert(sesion3);
            SesionService.GetInstance.Insert(sesion4);
            SesionService.GetInstance.Insert(sesion5);

            //TipoRT
            TipoRT tipoRT1 = new TipoRT(1, "TipoRT1", "DescripcionRT1");
            TipoRT tipoRT2 = new TipoRT(2, "TipoRT2", "DescripcionRT2");
            TipoRT tipoRT3 = new TipoRT(3, "TipoRT3", "DescripcionRT3");
            TipoRT tipoRT4 = new TipoRT(4, "TipoRT4", "DescripcionRT4");
            TipoRT tipoRT5 = new TipoRT(5, "TipoRT5", "DescripcionRT5");

            TipoRTService.GetInstance.Insert(tipoRT1);
            TipoRTService.GetInstance.Insert(tipoRT2);
            TipoRTService.GetInstance.Insert(tipoRT3);
            TipoRTService.GetInstance.Insert(tipoRT4);
            TipoRTService.GetInstance.Insert(tipoRT5);

            //Modelo
            Modelo modelo1 = new Modelo(1,"Modelo1");
            Modelo modelo2 = new Modelo(2,"Modelo2");
            Modelo modelo3 = new Modelo(3,"Modelo3");
            Modelo modelo4 = new Modelo(4,"Modelo4");
            Modelo modelo5 = new Modelo(5,"Modelo5");

            ModeloService.GetInstance.Insert(modelo1);
            ModeloService.GetInstance.Insert(modelo2);
            ModeloService.GetInstance.Insert(modelo3);
            ModeloService.GetInstance.Insert(modelo4);
            ModeloService.GetInstance.Insert(modelo5);

            //Marca
            Marca marca1 = new Marca(1,"Marca1");
            Marca marca2 = new Marca(2,"Marca2");
            Marca marca3 = new Marca(3,"Marca3");
            Marca marca4 = new Marca(4,"Marca4");
            Marca marca5 = new Marca(5,"Marca5");

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

            MarcaService.GetInstance.Insert(marca1);
            MarcaService.GetInstance.Insert(marca2);
            MarcaService.GetInstance.Insert(marca3);
            MarcaService.GetInstance.Insert(marca4);
            MarcaService.GetInstance.Insert(marca5);

            //Mantenimiento
            List<Mantenimiento> allMantenimientos = new List<Mantenimiento>();

            //Estado
            Estado estado1 = new Estado(1, "Disponible", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado2 = new Estado(2, "Ingresado", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado3 = new Estado(3, "Cancelado por mantenimiento preventivo", "Descripcion1", "Turno", true, true);
            Estado estado4 = new Estado(4, "Cancelado por mantenimiento correctivo", "Descripcion1", "Turno", true, true);
            Estado estado5 = new Estado(5, "Ingreso a mantenimiento preventivo", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado6 = new Estado(6, "Ingreso a mantenimiento preventivo", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado7 = new Estado(7, "Con reserva confirmada", "Descripcion1", "RecursoTecnologico", true, true);
            Estado estado8 = new Estado(8, "Pendiente de confirmacion de reserva", "Descripcion1", "RecursoTecnologico", true, true);

            EstadoService.GetInstance.Insert(estado1);
            EstadoService.GetInstance.Insert(estado2);
            EstadoService.GetInstance.Insert(estado3);
            EstadoService.GetInstance.Insert(estado4);
            EstadoService.GetInstance.Insert(estado5);
            EstadoService.GetInstance.Insert(estado6);
            EstadoService.GetInstance.Insert(estado7);
            EstadoService.GetInstance.Insert(estado8);

            //CambioEstadoTurno
            List<CambioEstadoTurno> allCambiosEstadoTurnos = new List<CambioEstadoTurno>();
            CambioEstadoTurno cambioEstadoTurno1 = new CambioEstadoTurno(1, DateTime.Now, null, estado3);
            CambioEstadoTurno cambioEstadoTurno2 = new CambioEstadoTurno(2, DateTime.Now, null, estado4);

            CambioEstadoTurnoService.GetInstance.Insert(cambioEstadoTurno1);
            CambioEstadoTurnoService.GetInstance.Insert(cambioEstadoTurno2);

            //CambioEstadoRT
            CambioEstadoRT cambioEstadoRT1 = new CambioEstadoRT(1, DateTime.Now, null, estado1);
            CambioEstadoRT cambioEstadoRT2 = new CambioEstadoRT(2, DateTime.Now, null, estado2);
            CambioEstadoRT cambioEstadoRT3 = new CambioEstadoRT(3, DateTime.Now, null, estado5);
            CambioEstadoRT cambioEstadoRT4 = new CambioEstadoRT(4, DateTime.Now, null, estado6);
            CambioEstadoRT cambioEstadoRT5 = new CambioEstadoRT(5, DateTime.Now, null, estado7);
            CambioEstadoRT cambioEstadoRT6 = new CambioEstadoRT(6, DateTime.Now, null, estado8);

            CambioEstadoRTService.GetInstance.Insert(cambioEstadoRT1);
            CambioEstadoRTService.GetInstance.Insert(cambioEstadoRT2);
            CambioEstadoRTService.GetInstance.Insert(cambioEstadoRT3);
            CambioEstadoRTService.GetInstance.Insert(cambioEstadoRT4);
            CambioEstadoRTService.GetInstance.Insert(cambioEstadoRT5);
            CambioEstadoRTService.GetInstance.Insert(cambioEstadoRT6);

            //Turnos
            Turno turno1 = new Turno(1,DateTime.Now.AddDays(2).AddHours(2), DateTime.Now.AddDays(2).AddHours(4), DateTime.Now.AddDays(2).DayOfWeek.ToString(), DateTime.Now, allCambiosEstadoTurnos); //List<CambioEstadoTurno> ---> Sería una lista de IDs? o una lista de objetos CambioEstadoTunro?
            Turno turno2 = new Turno(2,DateTime.Now.AddDays(3).AddHours(2), DateTime.Now.AddDays(3).AddHours(4), DateTime.Now.AddDays(3).DayOfWeek.ToString(), DateTime.Now, allCambiosEstadoTurnos);
            Turno turno3 = new Turno(3,DateTime.Now.AddDays(2).AddHours(4), DateTime.Now.AddDays(2).AddHours(6), DateTime.Now.AddDays(2).DayOfWeek.ToString(), DateTime.Now, allCambiosEstadoTurnos);
            Turno turno4 = new Turno(4,DateTime.Now.AddDays(5).AddHours(1), DateTime.Now.AddDays(5).AddHours(3), DateTime.Now.AddDays(5).DayOfWeek.ToString(), DateTime.Now, allCambiosEstadoTurnos);
            Turno turno5 = new Turno(5,DateTime.Now.AddDays(12).AddHours(6), DateTime.Now.AddDays(12).AddHours(7), DateTime.Now.AddDays(12).DayOfWeek.ToString(), DateTime.Now, allCambiosEstadoTurnos);

            turno1.AgregarCambioEstadoTurno(cambioEstadoTurno1);
            turno2.AgregarCambioEstadoTurno(cambioEstadoTurno2);
            turno3.AgregarCambioEstadoTurno(cambioEstadoTurno1);

            TurnoService.GetInstance.Insert(turno1);
            TurnoService.GetInstance.Insert(turno2);
            TurnoService.GetInstance.Insert(turno3);
            TurnoService.GetInstance.Insert(turno4);
            TurnoService.GetInstance.Insert(turno5);

            //RecursoTecnologico
            List<RecursoTecnologico> allRecursosTecnologicos = new List<RecursoTecnologico>();
            //RecursoTecnologico recursoTecnologico1 = new RecursoTecnologico(1, "RT1", modelo1, tipoRT1, null, null, null);
        }
    }
}