namespace Domain.Models.Person;


public class Person{
    public string Name {get; private set;}
    public string LastName {get; private set;}
    public string CPF {get; private set;}
    public int Age {get; private set;}
    public string Password {get; private set;}
    public string Role {get; private set;}

    //Adicional Contact Information

    public string EAddress { get; set; }
    public string EExtension { get; set; }
    public string CCity { get; set; }
    public string CState { get; set; }
    public string CStreet { get; set; }
    public string CNumber { get; set; }
    public string CNieghBorhood { get; set; }
    public string NNumber { get;  set; }
    public string NCountryCode { get;  set; }
    public string NDDD { get;  set; }
    public bool IsEmergencyContact { get;  set; }


    public Person(string lastName, string name, string cpf, int age, string password, string role){
        Name = name;
        LastName = lastName;
        CPF = cpf;
        Age = age;
        Password = password;
        Role = role;
    }
}