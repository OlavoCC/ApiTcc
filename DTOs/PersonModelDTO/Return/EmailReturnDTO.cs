namespace DTOs.PersonModelDTO.Return;

public class EmailReturnDTO{
    public bool Sucess {get; set;}

    
    public EmailReturnDTO(bool sucess){
        Sucess = sucess;
    }
}