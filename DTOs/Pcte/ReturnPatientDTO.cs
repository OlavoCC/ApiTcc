namespace DTOs.Pcte;

public class ReturnPatientDTO{
    public int Id {get; set;}
    public string Role {get; set;}
    public ReturnPatientDTO(int id, string role){
        Id = id;
        Role = role;
    }
}