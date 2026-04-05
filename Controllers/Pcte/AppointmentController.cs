using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Pcte;
using DTOs.Appointment;
namespace API.Controllers.Pcte;

[ApiController]
[Route("api/[controller]")]
public class AppointmentController : ControllerBase
{
    private readonly IAppointment _appointmentService;
    public AppointmentController(IAppointment appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpPost("createAppointment")]
    public async Task<IActionResult> CreateAppointment([FromBody] EntryAppointmentDTO dto)
    {
        try
        {
            var result = await _appointmentService.CreateAppointmentAsync(dto);
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