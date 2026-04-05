using Domain.Models.Pcte;
using DTOs.Pcte;
using DTOs.Pcte.Register;
using Application.Interfaces;
using Data.Interface;
using Application.Response.Pcte;
namespace Application.Services;

public class PersonService : IPerson
{
    private readonly IPersonSQL _personSQL;
    public PersonService(IPersonSQL person)
    {
        _personSQL = person;
    }


    public async Task<Result<ReturnPatientDTO>> LoginAsync(LoginPatientDTO dto)
    {
        var patient = new Patient("", "", dto.CPF, 0, dto.Password, "");
        bool data = await _personSQL.LoginAsync(patient);
        if (data){
            var result = await _personSQL.GetId(dto.CPF);
            int id = result.Id;
            string role = result.Role;
            var returnDTO = new ReturnPatientDTO(id, role);
            return new Result<ReturnPatientDTO>()
            {
                Data = returnDTO,
                Message = "Login successful"
            };
        }
        else{
            return new Result<ReturnPatientDTO>()
            {
                Data = null,
                Message = "Invalid CPF or password"
            };
        }
    }

}