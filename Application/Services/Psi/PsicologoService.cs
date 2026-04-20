using Application.Interfaces.Psi;
using DTOs.Psi;
using Application.Response.Psi;
using Data.Interface.Psi;
using DTOs.PersonModelDTO.Return;
using Domain.Models.Psi;
using DTOs.Psi.Register;

public class PsicologoService : IPsicologo
{
    private readonly IPsicologoSQL _psicologoSQL;
    public PsicologoService(IPsicologoSQL psicologoSQL)
    {
        _psicologoSQL = psicologoSQL;
    }
    public async Task<Result<IEnumerable<ListPsicologoDTO>>> ListPsicologo()
    {
        var result = await _psicologoSQL.ListPsicologo();
        if (result != null && result.Any())
        {
            var a = new Result<IEnumerable<ListPsicologoDTO>>
            {
                Message = "Sucess",
                Data = result
            };
            return a;
        }
        else
        {
            var a = new Result<IEnumerable<ListPsicologoDTO>>
            {
                Message = "Error",
                Data = null
            };
            return a;
        }
        
    }

    public async Task<Result<ReturnPersonDTO>> RegisterPsicologo(EntryPsicologoDTO dto)
    {
        var psciologo = new Psicologo(0, dto.Name, dto.LastName, dto.CPF, dto.Age, dto.Password, dto.Espciacilization, dto.CRP);
        var result = await _psicologoSQL.RegisterPsicologo(psciologo);
        if (result.Id != 0)
        {
            var a = new Result<ReturnPersonDTO>
            {
                Message = "Sucess",
                Data = result
            };
            return a;
        }
        else
        {
            var a = new Result<ReturnPersonDTO>
            {
                Message = "Error",
                Data = null
            };
            return a;
        }
    }
}