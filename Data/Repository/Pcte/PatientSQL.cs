namespace Data.Repository.Pcte;
using Data.Interface.Pcte;
using Domain.Models.Pcte;
using Domain.Models.Appointment;
using Domain.Models.Person;

public class PatientSQL : IPatientSQL
{
    public async Task <int>CreatePatientAsync(Patient patient)
    {
        int id = 0;
        return id;
    }

    
    
    

    public async Task<bool>CreateAdressAsync(Adress adress)
    {
        
        if(adress.IsApartment){
            return true;
        }
        else{
            return true;
        }
    }

    public async Task<bool>CreatePhoneNumberAsync(Number number)
    {
        if(number.IsEmergencyContact){
            return true;
        }
        else{
            return true;
        }
    }

    public async Task<bool> CreateEmailAsync(Email email)
    {
        return true;
    }
}