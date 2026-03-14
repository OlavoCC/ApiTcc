namespace Domain.Models.Pcte;
using Domain.Models.Person;

public class Patient : Person{
    public int PatientId {get; private set;}
    public Patient(string lastName, string name, string cpf, int age, string password) : base(lastName, name, cpf, age, password, role: "C"){
    }
}