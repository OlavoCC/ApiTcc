using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Pcte;
using DTOs.Pcte.Register;
using Application.Interfaces;
using Application.Services;
using DTOs.PersonModelDTO;
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
    public async Task<IActionResult> LoginAsync([FromBody] LoginPatientDTO dto){
        var result = await _person.LoginAsync(dto);
        return Ok(result);
    }

    

}