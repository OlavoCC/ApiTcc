namespace Data.Interface;
using Domain.Models.Person;
using Domain.Models.Pcte;
using DTOs.Pcte;

public interface IPersonSQL
{
    Task<(bool Success, string Role)> LoginAsync(Person person);
    Task<int> GetId(string cpf, string Role);


}