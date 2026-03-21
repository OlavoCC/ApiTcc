using Application.Interfaces.Pcte;
using Domain.Models.Pcte;
using Domain.Models.Person;
using DTOs.Pcte;
using DTOs.Pcte.Register;
using DTOs.PersonModelDTO.Return;
using DTOs.PersonModelDTO;
using Data.Interface.Pcte;
namespace Application.Services.Pcte;

public class PatientService : IPatient
{
    private readonly IPatientSQL _patientSQL;
    public PatientService(IPatientSQL patient)
    {
        _patientSQL = patient;
    }

    //Register

    public async Task<ReturnPatientDTO> CreatePatientAsync(RegisterPatientDTO dto)
    {
        var patient = new Patient(dto.Name, dto.LastName, dto.CPF, dto.Age, dto.Password);
        int data = await _patientSQL.CreatePatientAsync(patient);
        var returnDTO = new ReturnPatientDTO(data, patient.Role);
        return returnDTO;
    }

    //Login


    public async Task<AdressReturnDTO> CreateAdressAsync(AddressEntryDTO dto)
    {
        var adress = new Adress(dto.CEP, dto.City, dto.State, dto.Street, dto.Number, dto.Neighborhood, dto.IsApartment, dto.floor, dto.ApartmentNumber);
        bool data = await _patientSQL.CreateAdressAsync(adress);
        if (data)
        {
            var returnDTO = new AdressReturnDTO(data);
            return returnDTO;
        }
        return null;
    }

    public async Task<PhoneNumberReturnDTO> CreatePhoneNumberAsync(PhoneNumberEntryDTO dto)
    {
        var number = new Number(dto.Id, dto.Number, dto.CountryCode, dto.DDD, dto.IsEmergencyContact);
        bool data = await _patientSQL.CreatePhoneNumberAsync(number);
        if (data)
        {
            var returnDTO = new PhoneNumberReturnDTO(data);
            return returnDTO;
        }
        return null;
    }

    public async Task <EmailReturnDTO> CreateEmailAsync(EmailEntryDTO dto)
    {
        var email = new Email(dto.Id, dto.Address, dto.Extension);
        bool data = await _patientSQL.CreateEmailAsync(email);
        var returnDTO = new EmailReturnDTO(data);
        return (returnDTO);
    }
}