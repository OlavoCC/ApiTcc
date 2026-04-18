using DTOs.PersonModelDTO;
using DTOs.PersonModelDTO.Return;
namespace Application.Interfaces;
public interface IAuth
{
    string newToken(int id, string role);
}