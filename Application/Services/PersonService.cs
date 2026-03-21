using Domain.Models.Pcte;
using DTOs.Pcte;
using DTOs.Pcte.Register;
using Application.Interfaces;
using Data.Interface;
namespace Application.Services;

public class PersonService : IPerson
{
    private readonly IPersonSQL _personSQL;
    public PersonService(IPersonSQL person)
    {
        _personSQL = person;
    }


    public async Task<ReturnPatientDTO> LoginAsync(LoginPatientDTO dto)
    {
        var patient = new Patient("", "", dto.CPF, 0, dto.Password, "");
        bool data = await _personSQL.LoginAsync(patient);
        if (data){
            var result = await _personSQL.GetId(dto.CPF);
            int id = result.Id;
            string role = result.Role;
            var returnDTO = new ReturnPatientDTO(id, role);
            return returnDTO;
        }
        else{
            return null;
        }
    }

}