namespace Data.Interface;
using Domain.Models.Person;
using Domain.Models.Pcte;
public interface IPersonSQL
{
    Task <bool>LoginAsync(Person person);
    Task <(int Id, string Role)>GetId(string cpf);

}