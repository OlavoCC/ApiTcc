namespace DTOs.Psi.Register;
using System.ComponentModel.DataAnnotations;
using DTOs.PersonModelDTO;

public class EntryPsicologoDTO : PersonDTOModel{

    [Required(ErrorMessage = "CRP is requiered")]
    [MinLength(17, ErrorMessage = "CRP requiered 17 character")]
    [MaxLength(17, ErrorMessage = "CRP requiered 17 character")]
    public string CRP {get; set;}

    [Required(ErrorMessage = "Especiacilization is requiered")]
    [MaxLength(50, ErrorMessage = "Especiacilization must be at most 50 characters long")]
    public string Espciacilization {get; set;}

}