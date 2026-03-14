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
builder.Services.AddScoped<IPatientCreateSQL, CreateSQLPatient>();
builder.Services.AddScoped<IPatientCreate, PatientCreateService>();


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