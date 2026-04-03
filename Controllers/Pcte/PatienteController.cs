using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Pcte;
using DTOs.Pcte.Register;
using DTOs.Appointment;
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

    [HttpPost("createPatient")]
    public async Task<IActionResult> CreatePatient([FromBody] RegisterPatientDTO dto)
    {
        var result = await _patient.CreatePatientAsync(dto);
        if (result.Data != null)
        {
            return Ok(result);
        }
        return BadRequest(result);    
    }

    [HttpPost("createAdress")]
    public async Task<IActionResult> CreateAdress([FromBody] AddressEntryDTO dto){
        var result = await _patient.CreateAdressAsync(dto);
        if (result.Data != null)
        {
            return Ok(result);
        }
        return BadRequest(result); 
    }

    [HttpPost("createNumber")]
    public async Task <IActionResult> CreatePhoneNumberAsync([FromBody] PhoneNumberEntryDTO dto)
    {
        var result = await _patient.CreatePhoneNumberAsync(dto);
        if (result.Data != null)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("createEmail")]
    public async Task<IActionResult> CreateEmailAsync([FromBody] EmailEntryDTO dto)
    {
        var result = await _patient.CreateEmailAsync(dto);
        if (result.Data != null)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
    
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetPatientById(int id)
    {
        try
        {
            var result = await _patient.GetPatientByIdAsync(id);
            if (result.Data != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

}