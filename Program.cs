using Data.Repository.Pcte;
using Data.Interface.Pcte;
using Application.Services.Pcte;
using Application.Interfaces.Pcte;

// ensure the service interface is registered with its implementation

var builder = WebApplication.CreateBuilder(args);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

// register application services before the container is built
//builder.Services.AddScoped<>();
builder.Services.AddScoped<IPatientSQL, PatientSQL>();
builder.Services.AddScoped<IPatient, PatientService>();
builder.Services.AddScoped<IAppointment, AppointmentService>();
builder.Services.AddScoped<IAppointmentSQL, AppointmentSQL>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();