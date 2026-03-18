namespace Domain.Models.Appointment;


public class Appointment
{
    public int Id { get; private set; }
    public string Type { get; private set; } 
    public DateTime Date { get; private set; }
    public string Notes { get; private set; }
    public int PatientId { get; private set; }
    public int PsychologistId { get; private set; }
    public bool HadTreatment { get; private set; }
    public string PhysicalHeath { get; private set; }
    public char MaritalStatus { get; private set; }
    public string Habits { get; private set; }
    public string Searchreason { get; private set; }
    public Appointment(string type, DateTime date, string notes, int patientId, int psychologistId)
    {

        Type = type;
        Date = date;
        Notes = notes;
        PatientId = patientId;
        PsychologistId = psychologistId;
        
    }
}