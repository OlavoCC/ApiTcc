using Application.Interfaces.Pcte;
using Data.Interface.Pcte;
using DTOs.Appointment;
using Domain.Models.Appointment;
using Application.Response.Pcte;
namespace Application.Services.Pcte;

public class AppointmentService : IAppointment
{
    private readonly IAppointmentSQL _appointmentSQL;
    public AppointmentService(IAppointmentSQL appointmentSQL)
    {
        _appointmentSQL = appointmentSQL;
    }

    public async Task<Result<ReturnAppointmentDTO>> CreateAppointmentAsync(EntryAppointmentDTO dto)
    {
        var appointment = new Appointment(dto.Type, dto.Date, dto.PatientId, dto.PsychologistId);
        int data = await _appointmentSQL.CreateAppointmentAsync(appointment);
        if (data <= 0)
        {
            return new Result<ReturnAppointmentDTO>
            {
              Message = "Erro ao criar consulta"  
            };
        }
        var returnDTO = new ReturnAppointmentDTO(data, appointment.Type, appointment.Date, appointment.PatientId, appointment.PsychologistId);
        return new Result<ReturnAppointmentDTO>
        {
            Message = "Consulta criada com sucesso",
            Data = returnDTO
        };
    }
}