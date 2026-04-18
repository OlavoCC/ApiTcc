namespace Data.Interface.Psi;
using DTOs.Psi;
using Domain.Models.Psi;
using DTOs.PersonModelDTO.Return;
public interface IPsicologoSQL
{
    Task<IEnumerable<ListPsicologoDTO>> ListPsicologo();
    Task<ReturnPersonDTO> RegisterPsicologo(Psicologo p);
}