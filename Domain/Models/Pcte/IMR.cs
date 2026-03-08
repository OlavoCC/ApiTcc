//InitialMedicalRecord
namespace Domain.Models.Pcte;

public class IMR
{
    public int Id {get; private set;}
    public bool HadTretment {get; private set;}
    public string PhysicalHealth {get; private set;}
    public string MaritalStatus {get; private set;}
    public string Habits {get; private set;}
    public string SearchReason {get; private set;}
    public int PatientId {get; private set;}

    public IMR(int id, bool hadTretment, string physicalHealth, string maritalStatus, string habits, string searchReason, int patientId)
    {
        Id = id;
        HadTretment = hadTretment;
        PhysicalHealth = physicalHealth;
        MaritalStatus = maritalStatus;
        Habits = habits;
        SearchReason = searchReason;
        PatientId = patientId;
    }
}