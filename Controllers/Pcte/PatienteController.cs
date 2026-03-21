using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Pcte;
using DTOs.Pcte.Register;
namespace API.Controllers.Pcte;

[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly IPatientCreate _patientCreate;
    public PatientController(IPatientCreate patientCreate)
    {
        _patientCreate = patientCreate;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreatePatient(RegisterPatientDTO dto)
    {
        var result = await _patientCreate.CreatePatientAsync(dto);
        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginPatientAsync(LoginPatientDTO dto){
        var result = await _patientCreate.LoginPatientAsync(dto);
        return Ok(result);
    }
}