using Data.Interface.Psi;
using DTOs.Psi;
using Domain.Models.Psi;
using DTOs.PersonModelDTO.Return;
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

    public async Task<ReturnPersonDTO> RegisterPsicologo(Psicologo p)
    {
        string name = p.Name;
        string lastName = p.LastName;
        string cpf = p.CPF;
        string age = p.Age;
        string password = p.Password;
        string role = p.Role;
        string crp = p.CRP;
        string espciacilization = p.Espciacilization;
        int id = 1;
        var a = new ReturnPersonDTO(id, role, "");
        return a;
    }
}
