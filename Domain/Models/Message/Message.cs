namespace Domain.Models.Message;

public class Message
{
    public int Id {get; private set;}
    public bool Send {get; private set;}
    public bool Read {get; private set;}
    public string Content {get; private set;}
    public int SenderId {get; private set;}
    public int ReceiverId {get; private set;}
    public Message(string content, int senderId, int receiverId, bool send, bool read, int id)
    {
        Id = id;
        Content = content;
        SenderId = senderId;
        Send = send;
        Read = read;
        ReceiverId = receiverId;
    }
}