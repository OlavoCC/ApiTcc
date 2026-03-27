using System.Runtime.CompilerServices;
using Google.Protobuf;

namespace DTOs.PersonModelDTO.Return;


public class AdressReturnDTO{
    public int Id {get; set;}
    public string CEP {get; set;}
    public string City {get; set;}
    public string State {get; set;}
    public string Number {get; set;}
    public bool IsApartment {get; set;}
    public int ApartmentNumber {get; set;}


    public AdressReturnDTO(int id, string cep, string city, string state, string number, bool isApartment, int apartmentNumber)
    {
        Id = id;
        CEP = cep;
        City = city;
        State = state;
        Number = number;
        IsApartment = isApartment;
        ApartmentNumber = apartmentNumber;
    }

}