namespace DTOs.PersonModelDTO.Return;


public class AdressReturnDTO{

    public bool Success {get; set;}
    
    public AdressReturnDTO(bool success)
    {
        Success = success;
    }

}