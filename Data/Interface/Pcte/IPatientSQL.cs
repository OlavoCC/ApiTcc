using Domain.Models.Pcte;
using Domain.Models.Person;
namespace Data.Interface.Pcte;

public interface IPatientSQL
{
    Task <int>CreatePatientAsync(Patient patient);
    Task <bool>LoginAsync(Person person);
    Task <(int Id, string Role)>GetIdPatient(string cpf);
    Task <bool>CreateAdressAsync(Adress adress);
    Task <bool>CreatePhoneNumberAsync(Number number);
    Task <bool>CreateEmailAsync(Email email);
}
