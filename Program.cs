using Data.Repository.Pcte;
using Data.Interface.Pcte;
using Application.Services.Pcte;
using Application.Interfaces.Pcte;

var builder = WebApplication.CreateBuilder(args);

// 🔥 CORS CONFIG
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

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 🔥 MUITO IMPORTANTE: ordem
app.UseHttpsRedirection();

app.UseCors("AllowFrontend"); // 👈 AQUI

app.UseAuthorization();

app.MapControllers();

app.Run();