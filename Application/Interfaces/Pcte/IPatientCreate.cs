namespace Application.Interfaces.Pcte;
using DTOs.Pcte;

public interface IPatientCreate
{
    Task <ReturnPatientDTO> CreatePatientAsync(RegisterPatientDTO dto);
}