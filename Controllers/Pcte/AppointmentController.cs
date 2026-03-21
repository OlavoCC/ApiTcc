using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Pcte;
using DTOs.Pcte.Appointment;
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

    [HttpPost("create")]
    public async Task<IActionResult> CreateAppointment(NewAppointmentDTO dto)
    {
        var result = await _appointmentService.CreateAppointmentAsync(dto);
        return Ok(result);
    }

    
}