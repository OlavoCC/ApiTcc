namespace Domain.Models.Psi;
using Domain.Models.Person;

public class Psicologo : Person{
    public string CRP {get; private set;}
    public string Espciacilization {get; private set;}
    public int PsychologistId {get; private set;}

    public Psicologo(string lastName, int id, string name, string cpf, int age, string password, string espciacilization, string crp, string email, int psychologistId) : base(lastName, name, cpf, age, password, email, id, role: "P"){
        CRP = crp;
        Espciacilization = espciacilization;
        PsychologistId = psychologistId;
    }
}