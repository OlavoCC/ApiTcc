namespace Domain.Models.Appointment;

public class Report
{
    public int Id {get; private set;}
    public string EmotinalState {get; private set;}
    public int AppointmentId {get; private set;}

    public Report(int id, string emotinalState, int appointmentId)
    {
        Id = id;
        EmotinalState = emotinalState;
        AppointmentId = appointmentId;
    }
}