namespace Domain.Models.Pcte;

public class EmergencyContact
{
    public int Id {get; private set;}
    public string Name {get; private set;}
    public int IMRId {get; private set;}
    public int PhoneNumberId {get; private set;}

    public EmergencyContact(string name, int imrId, int phoneNumberId)
    {
        Name = name;
        IMRId = imrId;
        PhoneNumberId = phoneNumberId;
    }
}