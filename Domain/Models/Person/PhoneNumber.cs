namespace Domain.Models.Pcte;

public class PhoneNumber
{
    public int Id { get; private set; }
    public string Number { get; private set; }
    public int PersonId { get; private set; }
    public string CountryCode { get; private set; }
    public string DDD { get; private set; }

    public PhoneNumber(string number, int personId, int id, string ddd, string countryCode)
    {
        Id = id;
        Number = number;
        PersonId = personId;
        DDD = ddd;
        CountryCode = countryCode;
    }
}