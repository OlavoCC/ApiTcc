using Application.Interfaces.Pcte;
using Domain.Models.Pcte;
using Domain.Models.Person;
using DTOs.Pcte;
using DTOs.Pcte.Register;
using DTOs.PersonModelDTO.Return;
using DTOs.PersonModelDTO;
using Data.Interface.Pcte;
using Application.Response.Pcte;
namespace Application.Services.Pcte;

public class PatientService : IPatient
{
    private readonly IPatientSQL _patientSQL;
    public PatientService(IPatientSQL patient)
    {
        _patientSQL = patient;
    }

    //Register

    public async Task<Result<ReturnPatientDTO>> CreatePatientAsync(RegisterPatientDTO dto)
    {
        var patient = new Patient(dto.Name, dto.LastName, dto.CPF, dto.Age, dto.Password);
        int data = await _patientSQL.CreatePatientAsync(patient);
        if (data <= 0)
        {
            var result = new Result<ReturnPatientDTO>
            {
                Message = "Erro ao criar paciente",

            };
            return result;
        }
        var returndto = new ReturnPatientDTO(data, "C");
        return new Result<ReturnPatientDTO>
        {
            Message = "Paceinte criado com sucesso",
            Data = returndto
        };
    }

    //Login


    public async Task<Result<AdressReturnDTO>> CreateAdressAsync(AddressEntryDTO dto)
    {
        var adress = new Adress(dto.CEP, dto.City, dto.State, dto.Street, dto.Number, dto.Neighborhood, dto.IsApartment, dto.floor, dto.ApartmentNumber);
        int data = await _patientSQL.CreateAdressAsync(adress);
        if(data <= 0)
        {
            var result = new Result<AdressReturnDTO>
            {
                Message = "Ërro ao inserir Endereco"
            };
            return result;
        }
        var returnDTO = new AdressReturnDTO(data, adress.CEP, adress.CCity, adress.CState, adress.CNumber, adress.IsApartment, adress.ApartmentNumber);
        return new Result<AdressReturnDTO>
        {
            Message = "Endreco criado com sucesso",
            Data = returnDTO
        };
    }

    public async Task<Result<PhoneNumberReturnDTO>> CreatePhoneNumberAsync(PhoneNumberEntryDTO dto)
    {
        var number = new Number(dto.Id, dto.Number, dto.CountryCode, dto.DDD, dto.IsEmergencyContact);
        int data = await _patientSQL.CreatePhoneNumberAsync(number);
        if (data <= 0)
        {
            return new Result<PhoneNumberReturnDTO>
            {
              Message = "Erro ao criar numero de telefone"  
            };
        }
        var returnDTO = new PhoneNumberReturnDTO(data, number.NNumber, number.NDDD);
        return new Result<PhoneNumberReturnDTO>{
            Message = "Numero de telefone criado com sucesso",
            Data = returnDTO
        };
    }

    public async Task <Result<EmailReturnDTO>> CreateEmailAsync(EmailEntryDTO dto)
    {
        var email = new Email(dto.Id, dto.Address, dto.Extension);
        int data = await _patientSQL.CreateEmailAsync(email);
        if (data <= 0)
        {
            return new Result<EmailReturnDTO>
            {
              Message = "Erro ao criar email"  
            };
        }
        var returnDTO = new EmailReturnDTO(data, email.EAddress, email.EExtension);
        return new Result<EmailReturnDTO>
        {
          Message = "Email criado com sucesso",
          Data = returnDTO  
        };
    }
}