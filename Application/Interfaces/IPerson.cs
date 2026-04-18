using DTOs.Pcte.Register;
using Application.Response.Pcte;
using DTOs.Pcte;
using DTOs.PersonModelDTO;
using DTOs.PersonModelDTO.Return;

namespace Application.Interfaces;

public interface IPerson
{    
    Task <Result<ReturnPersonDTO>> LoginAsync(LoginPersonDTO dto);
}