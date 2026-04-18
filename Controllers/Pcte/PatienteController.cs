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
        try
        {
            var result = await _patient.CreatePatientAsync(dto);
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

    [HttpPost("createAdress")]
    public async Task<IActionResult> CreateAdress([FromBody] AddressEntryDTO dto)
    {
        try
        {
            var result = await _patient.CreateAdressAsync(dto);
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

    [HttpPost("createNumber")]
    public async Task<IActionResult> CreatePhoneNumberAsync([FromBody] PhoneNumberEntryDTO dto)
    {
        try
        {
            var result = await _patient.CreatePhoneNumberAsync(dto);
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

    [HttpPost("createEmail")]
    public async Task<IActionResult> CreateEmailAsync([FromBody] EmailEntryDTO dto)
    {
        try
        {
            var result = await _patient.CreateEmailAsync(dto);
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
    [HttpGet("ListPatient")]
    public async Task<IActionResult> ListPatient()
    {
        try
        {
            var result = await _patient.ListPatient();
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