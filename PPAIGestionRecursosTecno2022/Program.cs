
using PPAIGestionRecursosTecno2022;
using PPAIGestionRecursosTecno2022.DB;
using PPAIGestionRecursosTecno2022.Models;
using PPAIGestionRecursosTecno2022.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGenericService<AsignacionCientificoCI>, AsignacionCientificoCIService>();
builder.Services.AddScoped<IGenericService<AsignacionResponsableTecnicoRT>, AsignacionResponsableTecnicoRTService>();
builder.Services.AddScoped<IGenericService<CambioEstadoRT>, CambioEstadoRTService>();
builder.Services.AddScoped<IGenericService<CambioEstadoTurno>, CambioEstadoTurnoService>();
builder.Services.AddScoped<IGenericService<Estado>, EstadoService>();
builder.Services.AddScoped<IGenericService<Mantenimiento>, MantenimientoService>();
builder.Services.AddScoped<IGenericService<Marca>, MarcaService>();
builder.Services.AddScoped<IGenericService<Modelo>, ModeloService>();
builder.Services.AddScoped<IGenericService<PersonalCientifico>, PersonalCientificoService>();
builder.Services.AddScoped<IGenericService<RecursoTecnologico>, RecursoTecnologicoService>();
builder.Services.AddScoped<IGenericService<Sesion>, SesionService>();
builder.Services.AddScoped<IGenericService<TipoRT>, TipoRTService>();
builder.Services.AddScoped<IGenericService<Turno>, TurnoService>();
builder.Services.AddScoped<IGenericService<Usuario>, UsuarioService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

DB.Instance.cargarDatos(); //SE CARGAN LOS DATOS!

app.Run();
