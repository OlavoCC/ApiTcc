namespace Data.Interface.Psi;
using DTOs.Psi;
public interface IPsicologoSQL
{
    Task<IEnumerable<ListPsicologoDTO>> ListPsicologo();
}