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
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
builder.Services.AddScoped<IAuth, AuthService>();

var jwtKey = builder.Configuration["Jwt:Key"];
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))  
        };
    });
builder.Services.AddAuthorization();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowFrontend"); 

app.UseAuthentication(); 
app.UseAuthorization();

app.MapControllers();

app.Run();

DBConnection.Connection();


// Alteração para push no main

//Crar rotas: RegsiterPsy
//Criar TODAs as rotas de Edit
//Get id ADM, get id psy
