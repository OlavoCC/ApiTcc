using DTOs.Pcte.Register;
using DTOs.PersonModelDTO.Return;
using DTOs.PersonModelDTO;
using DTOs.Pcte;
using Application.Response.Pcte;
using Domain.Models.Person;

namespace Application.Interfaces.Pcte;

public interface IPatient
{
    Task<Result<ReturnPersonDTO>> CreatePatientAsync(RegisterPatientDTO dto);
    Task<Result<AdressReturnDTO>> CreateAdressAsync(AddressEntryDTO dto);
    Task<Result<PhoneNumberReturnDTO>> CreatePhoneNumberAsync(PhoneNumberEntryDTO dto);
    Task<Result<EmailReturnDTO>> CreateEmailAsync(EmailEntryDTO dto);
    Task<Result<Person>> GetPatientByIdAsync(int id);
    Task<Result<IEnumerable<ListPatientDTO>>> ListPatient();


}