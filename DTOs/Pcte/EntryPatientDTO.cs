namespace DTOs.Pcte;
//dotnet add package System.ComponentModel.Annotations
using System.ComponentModel.DataAnnotations;


public class EntryPatientDTO{
    
    [Required(ErrorMessage = "Name is requiered")]
    [MaxLength(45, ErrorMessage = "Name must be at most 45 characters long")]
    public string Name {get; set;}

    [Required(ErrorMessage = "City is requiered")]
    public string City {get; set;}

    [Required(ErrorMessage = "State is requiered")]
    public string State {get; set;}

    [Required(ErrorMessage = "Street is requiered")]
    public string Street {get; set;}

    [Required(ErrorMessage = "Number is requiered")]
    public string Number {get; set;}

    [Required(ErrorMessage = "NieghBorhood is requiered")]
    public string NieghBorhood {get; set;}

    [Required(ErrorMessage = "CPF is requiered")]
    [MinLength(11, ErrorMessage = "CPF requiered 11 character")]
    [MaxLength(11, ErrorMessage = "CPF requiered 11 character")]
    public string CPF {get; set;}

    [Required(ErrorMessage = "Age is requiered")]
    [MaxLength(3, ErrorMessage = "Age must be at most 3 characters long")]
    [MinLength(1, ErrorMessage = "Age must be at least 1 character long")]

    public int Age {get; set;}
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
    [Required(ErrorMessage = "Age is requiered")]
    public string Password {get; set;}

    [Required(ErrorMessage = "Email is requiered")] 
    public string Email {get; set;}


    
}