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

    public async Task <bool>LoginAsync(Person person)
    {
        string cpf = person.CPF;
        string password = person.Password;
        return true;
    }
    
    public async Task <(int Id, string Role)>GetIdPatient(string cpf){
        int id = 0;
        string role = "c";
        return (id, role);
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