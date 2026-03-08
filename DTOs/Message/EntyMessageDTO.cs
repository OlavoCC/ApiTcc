namespace DTOs.Message;
using System.ComponentModel.DataAnnotations;
public class EntryMessageDTO
{
    
    [Required(ErrorMessage = "Content is required")]
    [MaxLength(255, ErrorMessage = "Content cannot exceed 255 characters")]
    public string Content {get; set;}
    [Required(ErrorMessage = "SenderId is required")]
    public int SenderId {get; set;}
    [Required(ErrorMessage = "ReceiverId is required")]
    public int ReceiverId {get; set;}
    [Required(ErrorMessage = "SendAI is required")]
    public bool SendAI {get; set;}
    [Required(ErrorMessage = "ReadAI is required")]
    public bool ReadAI {get; set;}
}