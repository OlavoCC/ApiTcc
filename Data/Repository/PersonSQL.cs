using Data.Interface;
namespace Data.Repository;
using Domain.Models.Person;
using DTOs.Pcte;

public class PersonSQL : IPersonSQL
{
    public async Task<bool> LoginAsync(Person person)
    {
        string cpf = person.CPF;
        string password = person.Password;
        return true;
    }
    public async Task<(int Id, string Role)> GetId(string cpf)
    {
        
        int id = 0;
        string role = "C";
        return (id, role);
    }


}