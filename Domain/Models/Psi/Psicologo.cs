namespace Domain.Models.Psi;
using Domain.Models.Person;

public class Psicologo : Person{
    public string CRP {get; private set;}
    public string Espciacilization {get; private set;}
    public int PsychologistId {get; private set;}

    public Psicologo(string lastName, string name, string cpf, int age, string password, string espciacilization, string crp, string eAddress = "", string eExtension = "", string cCity = "", string cState = "", string cStreet = "", string cNumber = "", string cNieghBorhood = "", string nNumber = "", string nCountryCode = "", string nDDD = "") : base(lastName, name, cpf, age, password, "P", eAddress, eExtension, cCity, cState, cStreet, cNumber, cNieghBorhood, nNumber, nCountryCode, nDDD){
        CRP = crp;
        Espciacilization = espciacilization;
    }
}