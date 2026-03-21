using Domain.Models.Pcte;
using Domain.Models.Appointment;
namespace Data.Interface.Pcte;

public interface IAppointmentSQL
{
    Task <int>CreateAppointmentAsync(Appointment appointment);
}
