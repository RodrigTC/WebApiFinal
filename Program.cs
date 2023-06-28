using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .Add(new ServiceDescriptor(typeof(IUsuario),
    new UsuarioRepository()));

builder.Services
    .Add(new ServiceDescriptor(typeof(IEspecialidad),
    new EspecialidadRepository()));

builder.Services
    .Add(new ServiceDescriptor(typeof(IDoctor),
    new DoctorRepository()));

builder.Services
    .Add(new ServiceDescriptor(typeof(IHorarios),
    new HorarioRepository()));

builder.Services
    .Add(new ServiceDescriptor(typeof(ICita),
    new CitaRepository()));

builder.Services
    .Add(new ServiceDescriptor(typeof(IDia),
    new DiaRepository()));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
