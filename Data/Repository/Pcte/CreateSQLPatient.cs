namespace Data.Repository.Pcte;
using Data.Interface.Pcte;
using Domain.Models.Pcte;

public class CreateSQLPatient : IPatientCreateSQL
{
    public async Task <int>CreatePatientAsync(Patient patient)
    {
        int id = 0;
        return id;
    }

    public async Task <bool>LoginPatientAsync(Patient patient)
    {
        string cpf = patient.CPF;
        string password = patient.Password;
        return true;
    }
    
    public async Task <(int Id, string Role)>GetIdPatient(string cpf){
        int id = 0;
        string role = "c";
        return (id, role);
    }
}