using DTOs.Pcte.Register;
using DTOs.PersonModelDTO.Return;
using DTOs.PersonModelDTO;
using DTOs.Pcte;
using Application.Response.Pcte;

namespace Application.Interfaces.Pcte;

public interface IPatient
{
    Task <Result<ReturnPatientDTO>> CreatePatientAsync(RegisterPatientDTO dto);
    Task <Result<AdressReturnDTO>> CreateAdressAsync(AddressEntryDTO dto);
    Task <Result<PhoneNumberReturnDTO>> CreatePhoneNumberAsync(PhoneNumberEntryDTO dto);
    Task <Result<EmailReturnDTO>> CreateEmailAsync(EmailEntryDTO dto);
}