using DTOs.Pcte.Register;
using DTOs.PersonModelDTO.Return;
using DTOs.PersonModelDTO;
using DTOs.Pcte;

namespace Application.Interfaces.Pcte;

public interface IPatient
{
    Task <ReturnPatientDTO> CreatePatientAsync(RegisterPatientDTO dto);
    Task <ReturnPatientDTO> LoginPatientAsync(LoginPatientDTO dto);
    Task <AdressReturnDTO> CreateAdressAsync(AddressEntryDTO dto);
    Task <PhoneNumberReturnDTO> CreatePhoneNumberAsync(PhoneNumberEntryDTO dto);
    Task <EmailReturnDTO> CreateEmailAsync(EmailEntryDTO dto);
}