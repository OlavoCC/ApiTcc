namespace Domain.Models.Appointment;


public class Appointment
{
    public int Id { get; private set; }
    public string Type { get; private set; } 
    public DateTime Date { get; private set; }
    public string Notes { get; private set; }
    public int PatientId { get; private set; }
    public int PsychologistId { get; private set; }
    public Appointment(int id, string type, DateTime date, string notes, int patientId, int psychologistId)
    {
        Id = id;
        Type = type;
        Date = date;
        Notes = notes;
        PatientId = patientId;
        PsychologistId = psychologistId;
    }
}