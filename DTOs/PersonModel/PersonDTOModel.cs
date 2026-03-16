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
    [Range(1, 100)]
    public int Age {get; set;}

    [Required(ErrorMessage = "Password is Required")]
    [MinLength(6, ErrorMessage = "Password MinLenght = 6 char")]
    public string Password {get; set;}

    [Required(ErrorMessage = "Role ir Required")]
    [MaxLength(1, ErrorMessage = "Role MaxLenght = 1 char")]
    public string Role {get; set;}

    


}