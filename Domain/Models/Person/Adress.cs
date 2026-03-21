public class Adress
{
    public int Id { get; set; }
    public string CEP { get; private set; }
    public string CCity { get; private set; }
    public string CState { get; private set; }
    public string CStreet { get; private set; }
    public string CNumber { get; private set; }
    public string CNieghBorhood { get; private set; }
    public bool IsApartment { get; private set; }
    public int Floor { get; set; }
    public int ApartmentNumber { get; set; }


    public Adress(string cEP, string cCity, string cState, string cStreet, string cNumber, string cNieghBorhood, bool isApartment, int floor, int apartmentNumber)
    {

        CEP = cEP;
        CCity = cCity;
        CState = cState;
        CStreet = cStreet;
        CNumber = cNumber;
        CNieghBorhood = cNieghBorhood;
        IsApartment = isApartment;
    }
}