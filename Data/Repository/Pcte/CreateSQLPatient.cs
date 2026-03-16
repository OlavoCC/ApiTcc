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
}