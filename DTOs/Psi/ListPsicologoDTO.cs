namespace DTOs.Psi;
using System.ComponentModel.DataAnnotations;

public class ListPsicologoDTO
{
    [Required(ErrorMessage = "Name ir required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "LestName ir required")]
    public string LastName { get; set; }

    [Required (ErrorMessage = "CPF ir required")]
    public string CPF { get; set; }

    [Required (ErrorMessage = "Extension ir required")]
    public string Extension { get; set; }

    [Required (ErrorMessage = "Contrycode ir required")]
    public string CountryCode { get; set; }
    
    [Required (ErrorMessage = "DDD ir required")]
    public string DDD { get; set;}
    [Required (ErrorMessage = "CRM ir required")]
    public string CRM { get; set;}

    

    public ListPsicologoDTO(string name, string lastName, string cpf, string extension, string contrycode, string ddd, string crm){
        Name = name;
        LastName = lastName;
        CPF = cpf;
        Extension = extension;
        CountryCode = contrycode; 
        DDD = ddd; 
        CRM = crm;
    }
}