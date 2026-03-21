using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Pcte;
using DTOs.Pcte.Register;
using DTOs.Pcte.Appointment;
using DTOs.PersonModelDTO;
namespace API.Controllers.Pcte;

[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly IPatient _patient;
    public PatientController(IPatient patient)
    {
        _patient = patient;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreatePatient([FromBody] RegisterPatientDTO dto)
    {
        var result = await _patient.CreatePatientAsync(dto);
        return Ok(result);
    }

    [HttpPost("createAdress")]
    public async Task<IActionResult> CreateAdress([FromBody] AddressEntryDTO dto){
        var result = await _patient.CreateAdressAsync(dto);
        return Ok(result);
    }

    [HttpPost("createNumber")]
    public async Task <IActionResult> CreatePhoneNumberAsync([FromBody] PhoneNumberEntryDTO dto)
    {
        var result = await _patient.CreatePhoneNumberAsync(dto);
        return Ok(result);
    }

    [HttpPost("createEmail")]
    public async Task<IActionResult> CreateEmailAsync([FromBody] EmailEntryDTO dto)
    {
        var result = await _patient.CreateEmailAsync(dto);
        return Ok(result);
    }

}