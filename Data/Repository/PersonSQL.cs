using Data.Interface;
namespace Data.Repository;
using Domain.Models.Person;
using DTOs.Pcte;

public class PersonSQL : IPersonSQL
{
    public async Task<(bool Success, string Role)> LoginAsync(Person person)
    {
        string cpf = person.CPF;
        string password = person.Password;
        return (true, "C");
    }
    public async Task<int> GetId(string cpf, string Role)
    {
        
        int id = 0;
        return id;
    }


}