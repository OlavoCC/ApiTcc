using Domain.Models.Pcte;
namespace Data.Interface.Pcte;

public interface IPatientCreateSQL
{
    Task <int>CreatePatientAsync(Patient patient);
    Task <bool>LoginPatientAsync(Patient patient);
    Task <(int Id, string Role)>GetIdPatient(string cpf);
}
