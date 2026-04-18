namespace Application.Interfaces.Psi;
using DTOs.Psi;
using Application.Response.Psi;
using DTOs.Psi.Register;
using DTOs.PersonModelDTO.Return;

public interface IPsicologo
{
    Task<Result<IEnumerable<ListPsicologoDTO>>> ListPsicologo();
    Task<Result<ReturnPersonDTO>> RegisterPsicologo(EntryPsicologoDTO dto);
}