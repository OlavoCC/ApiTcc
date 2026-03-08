namespace Domain.Models.Pcte;
using Domain.Models.Person;

public class Patient : Person{
    public int PatientId {get; private set;}
    public Patient(string lastName, string name, string cpf, int age, string password, string email, int id, int patientId) : base(lastName, name, cpf, age, password, email, id, role: "C"){
        PatientId = patientId;
    }
}