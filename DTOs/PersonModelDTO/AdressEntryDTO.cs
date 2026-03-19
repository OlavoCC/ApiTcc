namespace DTOs.PersonModelDTO;
using System.ComponentModel.DataAnnotations;


public class AddressEntryDTO{

    [Required(ErrorMessage = "Id is required.")]
    public int Id {get; set;}
    
    [Required(ErrorMessage = "CEP is required.")]
    public string CEP {get; set;}

    [Required(ErrorMessage = "City is required.")]
    public string City {get; set;}

    [Required(ErrorMessage = "State is required.")]
    public string State {get; set;}

    [Required(ErrorMessage = "Street is required.")]
    public string Street {get; set;}

    [Required(ErrorMessage = "Number is required.")]
    public string Number {get; set;}

    [Required(ErrorMessage = "Neighborhood is required.")]
    public string Neighborhood {get; set;}

}