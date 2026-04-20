namespace Domain.Models.Psi;
using Domain.Models.Person;

public class Psicologo : Person{
    public string CRP {get; private set;}
    public string Espciacilization {get; private set;}
    public int PsychologistId {get; private set;}
    public Psicologo(){
        
    }
    public Psicologo(int id, string name, string lastName, string cpf, string age, string password, string espciacilization, string crp) : base(id, name, lastName, cpf, age, password, "P"){
        CRP = crp;
        Espciacilization = espciacilization;
    }
}