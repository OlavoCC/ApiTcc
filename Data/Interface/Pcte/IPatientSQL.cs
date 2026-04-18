using Domain.Models.Pcte;
using Domain.Models.Person;
using DTOs.Pcte;
namespace Data.Interface.Pcte;

public interface IPatientSQL
{
    Task<int> CreatePatientAsync(Patient patient);
    Task<int> CreateAdressAsync(Adress adress);
    Task<int> CreatePhoneNumberAsync(Number number);
    Task<int> CreateEmailAsync(Email email);
    Task<Patient> GetPatientFromIdAsync(int id);
    Task<IEnumerable<ListPatientDTO>> ListAllPatient();

}
