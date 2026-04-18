namespace DTOs.PersonModelDTO.Return;

public class ReturnPersonDTO{
    public int Id {get; set;}
    public string Token { get; set; }
    public string Role {get; set;}
    public ReturnPersonDTO(int id, string token, string role){
        Id = id;
        Token = token;
        Role = role;
    }
}