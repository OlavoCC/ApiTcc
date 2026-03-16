namespace Domain.Models.Person;


public class Person{
    public string Name {get; private set;}
    public string LastName {get; private set;}
    public string CPF {get; private set;}
    public int Age {get; private set;}
    public string Password {get; private set;}
    public string Role {get; private set;}
    public string EAddress { get; private set; }
    public string EExtension { get; private set; }
    public string CCity { get; set; }
    public string State { get; set; }
    public string CStreet { get; set; }
    public string CNumber { get; set; }
    public string CNieghBorhood { get; set; }
    public string NNumber { get; private set; }
    public string NCountryCode { get; private set; }
    public string NDDD { get; private set; }


    public Person(string lastName, string name, string cpf, int age, string password, string role, string eAddress, string eExtension, string cCity, string cState, string cStreet, string cNumber, string cNieghBorhood, string nNumber, string nCountryCode, string nDDD){
        Name = name;
        LastName = lastName;
        CPF = cpf;
        Age = age;
        Password = password;
        Role = role;
        EAddress = eAddress;
        EExtension = eExtension;
        CCity = cCity;
        State = cState;
        CStreet = cStreet;
        CNumber = cNumber;
        CNieghBorhood = cNieghBorhood;
        NNumber = nNumber;
        NCountryCode = nCountryCode;
        NDDD = nDDD;
    }
}