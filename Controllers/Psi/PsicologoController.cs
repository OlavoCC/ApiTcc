using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Psi;
using Application.Response.Psi;
using DTOs.Psi.Register;
using DTOs.Psi;

public class PsicologController : ControllerBase
{
    private readonly IPsicologo _psicologo;
    public PsicologController(IPsicologo psicologo)
    {
        _psicologo = psicologo;
    }
    [HttpGet("/api/ListPsicologo")]
    public async Task<IActionResult> ListPsicologo()
    {
        try
        {
            var result = await _psicologo.ListPsicologo();
            if (result.Data != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal Error: " + ex.Message);
        }
        
    }
    [HttpPost("/api/RegisterPsicologo")]
    public async Task<IActionResult> RegisterPsicologo([FromBody] EntryPsicologoDTO dto)
    {
        try
        {
            var result = await _psicologo.RegisterPsicologo(dto);
            if (result.Data != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal Error: " + ex.Message);
        }
    }
}