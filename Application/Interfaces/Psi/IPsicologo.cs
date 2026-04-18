namespace Application.Interfaces.Psi;
using DTOs.Psi;
using Application.Response.Psi;
public interface IPsicologo
{
    Task<Result<IEnumerable<ListPsicologoDTO>>> ListPsicologo();
}