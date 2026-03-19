public class Email
{
    public int id { get; private set; }
    public string EAddress { get; set; }
    public string EExtension { get; set; }

    public Email(int id, string eAddress, string eExtension)
    {
        this.id = id;
        EAddress = eAddress;
        EExtension = eExtension;
    }
}