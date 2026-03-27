namespace DTOs.Appointment;
public class ReturnAppointmentDTO
{
   public int Id { get; set; }
   public string Type { get; set; }
    public DateTime Date { get; set; }
    public int PatientId { get; set; }
    public int PsychologistId { get; set; }
    
    public ReturnAppointmentDTO(int id, string type, DateTime date, int patientId, int psychologistId)
   {
      this.Id = id;
      this.Type = type;
      this.Date = date;
      this.PatientId = patientId;
      this.PsychologistId = psychologistId;
   }

}