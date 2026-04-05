using DTOs.Pcte.Register;
using Application.Response.Pcte;
using DTOs.Pcte;
using Application.Response.Pcte;

namespace Application.Interfaces;

public interface IPerson
{    Task <Result<ReturnPatientDTO>> LoginAsync(LoginPatientDTO dto);

}