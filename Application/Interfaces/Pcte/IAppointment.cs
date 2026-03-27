namespace Application.Interfaces.Pcte;

using DTOs.Appointment;
using Application.Response.Pcte;
public interface IAppointment
{
    Task <Result<ReturnAppointmentDTO>> CreateAppointmentAsync(EntryAppointmentDTO dto);
}