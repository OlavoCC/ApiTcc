using Data.Interface.Psi;
using DTOs.Psi;
public class PsicologoSQL : IPsicologoSQL
{
    public async Task<IEnumerable<ListPsicologoDTO>> ListPsicologo()
    {
        var listpcte = new List<ListPsicologoDTO>
            {
                new ListPsicologoDTO("", "", "", "", "", "", "")
            };

            return listpcte;
        }
}
