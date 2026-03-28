namespace Data.Repository.Pcte;

using Data.Interface.Pcte;
using Domain.Models.Pcte;
using Domain.Models.Person;
using Properties;

public class PatientSQL : IPatientSQL
{
    
    public async Task <int>CreatePatientAsync(Patient patient)
    {
        using var connection = DBConnection.Connection();

        

        int id = 1;

        connection.Close();

        return id;
    }

    

    public async Task<int>CreateAdressAsync(Adress adress)
    {
        
        if(adress.IsApartment){
            int id = 0;
            return id;
        }
        else{
            int id = 0;
            return id;
        }
    }

    public async Task<int>CreatePhoneNumberAsync(Number number)
    {
        if(number.IsEmergencyContact){
            int id = 0;
            return id;
        }
        else{
           int id = 0;
            return id;
        }
    }

    public async Task<int> CreateEmailAsync(Email email)
    {
        int id = 0;
        return id;
    }
}