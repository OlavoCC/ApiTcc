namespace Domain.Models.Person;

public class Adress
{
    public string City { get; set; }
    public string State { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string NieghBorhood { get; set; }

    public Adress(string city, string state, string street, string number, string nieghBorhood)
    {
        City = city;
        State = state;
        Street = street;
        Number = number;
        NieghBorhood = nieghBorhood;
    }
}