namespace Application.Interfaces.Pcte;
using DTOs.Pcte.Register;
using DTOs.Pcte;
public interface IPatientCreate
{
    Task <ReturnPatientDTO> CreatePatientAsync(RegisterPatientDTO dto);
}