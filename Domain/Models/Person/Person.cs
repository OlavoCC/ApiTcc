namespace Domain.Models.Person;


public class Person{
    public int Id { get; private set; }
    public string Name {get; private set;}
    public string LastName {get; private set;}
    public string CPF {get; private set;}
    public string Age {get; private set;}
    public string Password {get; private set;}
    public string Role {get; private set;}

    public Person(){
    }

    public Person(int id, string name, string lastName, string cpf, string age, string password, string role){
        Id = id;
        Name = name;
        LastName = lastName;
        CPF = cpf;
        Age = age;
        Password = password;
        Role = role;
    }
}