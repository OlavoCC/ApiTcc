using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Pcte;
using DTOs.Pcte.Register;
using DTOs.Appointment;
using DTOs.PersonModelDTO;
using Application.Interfaces;
using Application.Services;
using Application.Response.Pcte;
using DTOs.PersonModelDTO.Return;
using Microsoft.AspNetCore.Authorization;
namespace API.Controllers.Pcte;
[Authorize]
[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly IPatient _patient;
    public PatientController(IPatient patient)
    {
        _patient = patient;
    }
    [Authorize(Roles = "P")]
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
    [Authorize(Roles = "C")]
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
    [Authorize(Roles = "C")]
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
    [Authorize(Roles = "C")]
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
    [Authorize(Roles = "P")]
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
    [Authorize(Roles = "P,A")]
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