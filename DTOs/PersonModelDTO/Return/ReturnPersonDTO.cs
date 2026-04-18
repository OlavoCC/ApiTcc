namespace DTOs.PersonModelDTO.Return;

public class ReturnPersonDTO{
    public int Id {get; set;}
    public string Role {get; set;}
    public ReturnPersonDTO(int id, string role){
        Id = id;
        Role = role;
    }
}