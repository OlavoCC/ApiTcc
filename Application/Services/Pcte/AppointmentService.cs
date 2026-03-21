using Application.Interfaces.Pcte;
using Domain.Models.Pcte;
using Data.Interface.Pcte;
using DTOs.Pcte;
using DTOs.Pcte.Register;
using DTOs.Pcte.Appointment;
using Domain.Models.Appointment;
namespace Application.Services.Pcte;

public class AppointmentService : IAppointment
{
    private readonly IAppointmentSQL _appointmentSQL;
    public AppointmentService(IAppointmentSQL appointmentSQL)
    {
        _appointmentSQL = appointmentSQL;
    }

    public async Task<ReturnAppointmentDTO> CreateAppointmentAsync(NewAppointmentDTO dto)
    {
        var appointment = new Appointment(dto.Type, dto.Date, dto.PatientId, dto.PsychologistId);
        int data = await _appointmentSQL.CreateAppointmentAsync(appointment);
        var returnDTO = new ReturnAppointmentDTO(data);
        return returnDTO;
    }
}