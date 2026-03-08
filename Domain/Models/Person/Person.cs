namespace Domain.Models.Person;


public class Person{
    public int Id {get; private set;}
    public string Name {get; private set;}
    public string LastName {get; private set;}
    public string CPF {get; private set;}
    public int Age {get; private set;}
    public string Password {get; private set;}
    public string Email {get; private set;}
    public string Role {get; private set;}

    public Person(string lastName, string name, string cpf, int age, string password, string email, int id, string role){
        Id = id;
        Name = name;
        CPF = cpf;
        Age = age;
        Password = password;
        Email = email;
        Role = role;
        LastName = lastName;
    }
}