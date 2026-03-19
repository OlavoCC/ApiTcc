public class Adress
{
    public int Id { get; private set; }
    public string CEP { get; private set; }
    public string CCity { get; private set; }
    public string CState { get; private set; }
    public string CStreet { get; private set; }
    public string CNumber { get; private set; }
    public string CNieghBorhood { get; private set; }

    public Adress(int id, string cEP, string cCity, string cState, string cStreet, string cNumber, string cNieghBorhood)
    {
        Id = id;
        CEP = cEP;
        CCity = cCity;
        CState = cState;
        CStreet = cStreet;
        CNumber = cNumber;
        CNieghBorhood = cNieghBorhood;
    }
}