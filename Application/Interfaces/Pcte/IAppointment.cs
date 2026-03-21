namespace Application.Interfaces.Pcte;
using DTOs.Pcte.Appointment;
public interface IAppointment
{
    Task <ReturnAppointmentDTO> CreateAppointmentAsync(NewAppointmentDTO dto);
}