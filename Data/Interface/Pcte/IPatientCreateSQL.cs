using Domain.Models.Pcte;
namespace Data.Interface.Pcte;

public interface IPatientCreateSQL
{
    Task <int>CreatePatientAsync(Patient patient);
}
