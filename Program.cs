using Data.Repository.Pcte;
using Data.Interface.Pcte;
using Application.Services.Pcte;
using Application.Interfaces.Pcte;
using Data.Interface;
using Data.Repository;
using Application.Services;
using Application.Interfaces;
using Application.Interfaces.Psi;
using Data.Interface.Psi;
using Properties;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

// services
builder.Services.AddScoped<IPatientSQL, PatientSQL>();
builder.Services.AddScoped<IPatient, PatientService>();
builder.Services.AddScoped<IAppointment, AppointmentService>();
builder.Services.AddScoped<IAppointmentSQL, AppointmentSQL>();
builder.Services.AddScoped<IPersonSQL, PersonSQL>();
builder.Services.AddScoped<IPerson, PersonService>();
builder.Services.AddScoped<IPsicologo, PsicologoService>();
builder.Services.AddScoped<IPsicologoSQL, PsicologoSQL>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowFrontend"); 

app.UseAuthorization();

app.MapControllers();

app.Run();

DBConnection.Connection();


// Alteração para push no main

//Crar rotas: RegsiterPsy
//Criar TODAs as rotas de Edit
//Get id ADM, get id psy
