namespace DTOs.PersonModelDTO;
using System.ComponentModel.DataAnnotations;


public class LoginPersonDTO{
    [StringLength(11, MinimumLength = 11)]
    [Required(ErrorMessage = "CPF ir Required")]
    public string CPF {get; set;}
    [Required(ErrorMessage = "ID ir Required")]
    public string Password {get; set;}
}