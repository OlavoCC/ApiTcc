namespace Data.Repository.Pcte;

using Data.Interface.Pcte;
using Domain.Models.Pcte;
using Domain.Models.Person;
using Org.BouncyCastle.Bcpg.OpenPgp;
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

    public async Task <Patient> GetPatientFromIdAsync (int id)
    {
        bool sucess = true;
        if(!sucess)
        {
            return null;
        }
        string lastname = "";
        string name = "";
        string cpf = "";
        int age = 0;
        string password = ""; 
        string role = "";


        var patient = new Patient(lastname, name, cpf, age, password, role);
        return patient;
    }
}