using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Pcte;
using DTOs.Pcte.Register;
using Application.Interfaces;
using Application.Services;
using DTOs.PersonModelDTO;
using Application.Response.Pcte;
namespace API.Controllers.Pcte;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private readonly IPerson _person;
    public PersonController(IPerson person)
    {
        _person = person;
    }



    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginPersonDTO dto){
        try
        {
            var result = await _person.LoginAsync(dto);
            if (result.Data == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    

}