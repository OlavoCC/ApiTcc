namespace Data.Repository.Pcte;
using Data.Interface.Pcte;
using Domain.Models.Pcte;
using Microsoft.AspNetCore.Components.Web;

public class CreateSQLPatient : IPatientCreateSQL
{
    public async Task <int>CreatePatientAsync(Patient patient)
    {
        int id = 0;
        return id;
    }
}