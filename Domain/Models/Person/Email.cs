namespace Domain.Models.Person;

public class Email
{
    public string Address { get; private set; }
    public string Extension { get; private set; }
    public int PersonId { get; private set; }
    public Email(string address, string extension, int personId)
    {
        Address = address;
        Extension = extension;
        PersonId = personId;
    }
}