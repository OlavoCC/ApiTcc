namespace DTOs.Appointment;
using System.ComponentModel.DataAnnotations;
public class EntryAppointmentDTO
{
    [Required(ErrorMessage = "Type is required.")]
    [MaxLength(1, ErrorMessage = "Type must be a single character.")]
    public string Type { get; set; }
    [Required(ErrorMessage = "Date is required.")]
    public DateTime Date { get; set; }
    [Required(ErrorMessage = "Notes is required.")]
    public string Notes { get; set; }
    [Required(ErrorMessage = "PatientId is required.")]
    public int PatientId { get; set; }
    [Required(ErrorMessage = "PsychologistId is required.")]
    public int PsychologistId { get; set; }
}