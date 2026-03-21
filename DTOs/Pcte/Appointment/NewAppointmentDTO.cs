namespace DTOs.Pcte.Appointment;
using System.ComponentModel.DataAnnotations;

public class NewAppointmentDTO
{
    [Required]
    public string Type { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public int PatientId { get; set; }
    [Required]
    public int PsychologistId { get; set; }
    
}