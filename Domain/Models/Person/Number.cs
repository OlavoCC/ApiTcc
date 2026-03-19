public class Number
{
    public int Id { get; private set; }
    public string NNumber { get;  private set; }
    public string NCountryCode { get;  private set; }
    public string NDDD { get;  private set; }
    public bool IsEmergencyContact { get;  private set; }

    public Number(int id, string nNumber, string nCountryCode, string nDDD, bool isEmergencyContact)
    {
        Id = id;
        NNumber = nNumber;
        NCountryCode = nCountryCode;
        NDDD = nDDD;
        IsEmergencyContact = isEmergencyContact;
    }
}