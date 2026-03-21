using DTOs.Pcte.Register;
using DTOs.PersonModelDTO.Return;
using DTOs.PersonModelDTO;
using DTOs.Pcte;

namespace Application.Interfaces;

public interface IPerson
{    Task <ReturnPatientDTO> LoginAsync(LoginPatientDTO dto);

}