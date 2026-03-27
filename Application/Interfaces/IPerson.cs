using DTOs.Pcte.Register;
using Application.Response.Pcte;
using DTOs.Pcte;

namespace Application.Interfaces;

public interface IPerson
{    Task <ReturnPatientDTO> LoginAsync(LoginPatientDTO dto);

}