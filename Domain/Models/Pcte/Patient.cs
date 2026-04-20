namespace Domain.Models.Pcte;
using Domain.Models.Person;

public class Patient : Person{
    public int PatientId {get; private set;}
    public Patient()
    {
        
    }
    public Patient(int id, string name, string lastName, string cpf, string age, string password, string role = "C") : base(id, name, lastName, cpf, age, password, role){
    }
}