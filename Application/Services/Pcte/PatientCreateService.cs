using Application.Interfaces.Pcte;
using Domain.Models.Pcte;
using Data.Interface.Pcte;
using DTOs.Pcte;
using DTOs.Pcte.Register;
namespace Application.Services.Pcte;

public class PatientCreateService : IPatientCreate
{
    private readonly IPatientCreateSQL _patientCreate;
    public PatientCreateService(IPatientCreateSQL patientCreate)
    {
        _patientCreate = patientCreate;
    }

    public async Task<ReturnPatientDTO> CreatePatientAsync(RegisterPatientDTO dto)
    {
        var patient = new Patient(dto.Name, dto.LastName, dto.CPF, dto.Age, dto.Password);
        int data = await _patientCreate.CreatePatientAsync(patient);
        var returnDTO = new ReturnPatientDTO(data, patient.Role);
        return returnDTO;
    }

    public async Task<ReturnPatientDTO> LoginPatientAsync(LoginPatientDTO dto)
    {
        var patient = new Patient("", "", dto.CPF, 0, dto.Password, "");
        bool data = await _patientCreate.LoginPatientAsync(patient);
        if (data){
            var result = await _patientCreate.GetIdPatient(dto.CPF);
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