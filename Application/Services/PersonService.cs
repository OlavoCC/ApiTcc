using Domain.Models.Pcte;
using DTOs.Pcte;
using DTOs.Pcte.Register;
using Application.Interfaces;
using Data.Interface;
using Application.Response.Pcte;
using DTOs.PersonModelDTO.Return;
using DTOs.PersonModelDTO;
using Application.Interfaces.Pcte;
using DTOs.PersonModelDTO;
namespace Application.Services;

public class PersonService : IPerson

{
    private readonly IPersonSQL _personSQL;
    private readonly IAuth _auth;
    public PersonService(IPersonSQL person, IAuth auth)
    {
        _personSQL = person;
        _auth = auth;
    }


    public async Task<Result<ReturnPersonDTO>> LoginAsync(LoginPersonDTO dto)
    {
        var patient = new Patient(0, "", "", dto.CPF, "0", dto.Password, "");
        var data = await _personSQL.LoginAsync(patient);
        if (data.Success){
            int result = await _personSQL.GetId(dto.CPF, data.Role);
            string token = _auth.newToken(result, data.Role);
            
            var returnDTO = new ReturnPersonDTO(result, token, data.Role);
            return new Result<ReturnPersonDTO>()
            {
                Data = returnDTO,
                Message = "Login successful"
            };
        }
        else{
            return new Result<ReturnPersonDTO>()
            {
                Data = null,
                Message = "Invalid CPF or password"
            };
        }
    }

}