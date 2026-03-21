namespace Data.Repository.Pcte;
using Data.Interface.Pcte;
using Domain.Models.Pcte;
using Domain.Models.Appointment;

public class AppointmentSQL : IAppointmentSQL
{    
    public async Task <int>CreateAppointmentAsync(Appointment appointment)
    {   
        int id = 0;
        return id;
    }
}