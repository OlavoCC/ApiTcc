namespace DTOs.PersonModelDTO.Return;

public class PhoneNumberReturnDTO{
    public bool Sucess {get; set;}
    public PhoneNumberReturnDTO(bool sucess)
    {
        Sucess = sucess;
    }
}