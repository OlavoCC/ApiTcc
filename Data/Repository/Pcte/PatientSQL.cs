namespace Data.Repository.Pcte;

using Data.Interface.Pcte;
using Domain.Models.Pcte;
using Domain.Models.Person;
using DTOs.Pcte;
using Properties;

public class PatientSQL : IPatientSQL
{

    public async Task<int> CreatePatientAsync(Patient patient)
    {
        using var connection = DBConnection.Connection();



        int id = 1;

        connection.Close();

        return id;
    }



    public async Task<int> CreateAdressAsync(Adress adress)
    {

        if (adress.IsApartment)
        {
            int id = 0;
            return id;
        }
        else
        {
            int id = 0;
            return id;
        }
    }

    public async Task<int> CreatePhoneNumberAsync(Number number)
    {
        if (number.IsEmergencyContact)
        {
            int id = 0;
            return id;
        }
        else
        {
            int id = 0;
            return id;
        }
    }

    public async Task<int> CreateEmailAsync(Email email)
    {
        int id = 0;
        return id;
    }

    public async Task<Patient> GetPatientFromIdAsync(int id)
    {
        bool sucess = false;
        if (!sucess)
        {
            return null;
        }
        string lastname = "";
        string name = "";
        string cpf = "";
        string age = "0";
        string password = "";
        string role = "C";


        var patient = new Patient(id, name, lastname, cpf, age, password, role);
        return patient;
    }
    
        public async Task<IEnumerable<ListPatientDTO>> ListAllPatient(){
        var listpcte = new List<ListPatientDTO>
            {
                new ListPatientDTO("", "", "", "", "", "")
            };

            return listpcte;
        }
}