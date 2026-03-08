namespace DTOs.Psi;
using System.ComponentModel.DataAnnotations;


public class EntryPsicologoDTO{

    [Required(ErrorMessage = "Name is requiered")]
    [MaxLength(45, ErrorMessage = "Name must be at most 45 characters long")]
    public string Name {get; set;}

    [Required(ErrorMessage = "Adress is requiered")]
    public string Adress {get; set;}

    [Required(ErrorMessage = "CPF is requiered")]
    [MinLength(11, ErrorMessage = "CPF requiered 11 character")]
    [MaxLength(11, ErrorMessage = "CPF requiered 11 character")]
    public string CPF {get; set;}

    [Required(ErrorMessage = "CRP is requiered")]
    [MinLength(17, ErrorMessage = "CRP requiered 17 character")]
    [MaxLength(17, ErrorMessage = "CRP requiered 17 character")]
    public string CRP {get; set;}

    [Required(ErrorMessage = "Age is requiered")]
    [MaxLength(3, ErrorMessage = "Age must be at most 3 characters long")]
    [MinLength(1, ErrorMessage = "Age must be at least 1 character long")]
    public int Age {get; set;}

    [Required(ErrorMessage = "Especiacilization is requiered")]
    [MaxLength(50, ErrorMessage = "Especiacilization must be at most 50 characters long")]
    public string Espciacilization {get; set;}
     [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
    [Required(ErrorMessage = "Password is requiered")]
    public string Password {get; set;}
    [Required(ErrorMessage = "Email is requiered")]
    public string Email {get; set;}


    
}