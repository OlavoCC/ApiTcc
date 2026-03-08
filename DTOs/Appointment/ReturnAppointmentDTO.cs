namespace DTOs.Appointment;
public class ReturnAppointmentDTO
{
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public string Notes { get; set; }
    public string PatientName { get; set; }
    public string PsychologistName { get; set; }
}