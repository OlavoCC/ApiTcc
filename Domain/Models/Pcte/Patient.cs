namespace Domain.Models.Pcte;
using Domain.Models.Person;

public class Patient : Person{
    public int PatientId {get; private set;}
    public Patient(string lastName, string name, string cpf, int age, string password, string eAddress = "", string eExtension = "", string cCity = "", string cState = "", string cStreet = "", string cNumber = "", string cNieghBorhood = "", string nNumber = "", string nCountryCode = "", string nDDD = "") : base(lastName, name, cpf, age, password, "C", eAddress, eExtension, cCity, cState, cStreet, cNumber, cNieghBorhood, nNumber, nCountryCode, nDDD){
    }
}