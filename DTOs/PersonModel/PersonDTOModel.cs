namespace DTOs.PersonModel;
using System.ComponentModel.DataAnnotations;

public class PersonDTOModel{

    //Person

    [Required(ErrorMessage = "Name is Required")]
    public string Name {get; set;}

    [Required(ErrorMessage = "Last Name is Required")]
    public string LastName {get; set;}

    [Required(ErrorMessage = "CPF is required")]
    [StringLength(11, MinimumLength = 11)]
    public string CPF {get; set;}

    [Required(ErrorMessage = "Age is Required")]
    [Range(1, 120)]
    public int Age {get; set;}

    [Required(ErrorMessage = "Password is Required")]
    [MinLength(6, ErrorMessage = "Password MinLenght = 6 char")]
    public string Password {get; set;}

    [Required(ErrorMessage = "Role ir Required")]
    [MaxLength(1, ErrorMessage = "Role MaxLenght = 1 char")]
    public string Role {get; set;}

    //EMAIL

    [Required(ErrorMessage = "Adress ir required")]
    public string EAdress {get; set;}

    [Required(ErrorMessage = "Extension of adress ir required")]
    public string EExtension {get; set;}

    //PhoneNumber

    [Required(ErrorMessage = "Number ir required")]
    public string PNumber {get; set;}

    [Required(ErrorMessage = "Country Code ir required")]
    public string PCountryCode {get; set;}

    [Required(ErrorMessage = "DDD ir required")]
    public string PDDD {get; set;}

    //Adress

    [Required(ErrorMessage = "City is Required")]
    public string ACity {get; set;}

    [Required(ErrorMessage = "State is Required")]
    public string AState {get; set;}

    [Required(ErrorMessage = "Street is Required")]
    public string AStreet {get; set;}

    [Required(ErrorMessage = "Number is Required")]
    public string ANumber {get; set;}

    [Required(ErrorMessage = "NeighBohood is Required")]
    public string ANeighBohood {get; set;}


}