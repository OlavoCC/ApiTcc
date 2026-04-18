using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Psi;
using Application.Response.Psi;
using DTOs.Psi;

public class PsicologController : ControllerBase
{
    private readonly IPsicologo _psicologo;
    public PsicologController(IPsicologo psicologo)
    {
        _psicologo = psicologo;
    }
    [HttpGet("ListPsicologo")]
    public async Task<IActionResult> ListPsicologo()
    {
        var result = await _psicologo.ListPsicologo();
        if (result.Data != null)
        {
            return Ok(result);
        }
        else
        {
            return NotFound(result);
        }
    }
}