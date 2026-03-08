using Domain.Models.Pcte;
using DTOs.Pcte;

namespace Application.Interfaces.Pcte;

public interface IPatientTest{
    Task<ReturnPatientDTO> CreatePatient(EntryPatientDTO dto);
    Task<ReturnPatientDTO> GetAllPatient();
}