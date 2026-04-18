using Application.Interfaces.Psi;
using DTOs.Psi;
using Application.Response.Psi;
using Data.Interface.Psi;

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
                Message = "Sucess",
                Data = null
            };
            return a;
        }
        

    }
}