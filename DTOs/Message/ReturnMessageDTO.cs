namespace DTOs.Message;
public class ReturnMessageDTO
{
    public int Id {get; set;}
    public string Content {get; set;}
    public int SenderId {get; set;}
    public int ReceiverId {get; set;}
    public bool SendAI {get; set;}
    public bool ReadAI {get; set;}
}