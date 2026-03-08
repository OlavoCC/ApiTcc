namespace Domain.Models.Payment;

public class Payment{
    public int Id {get; private set;}
    public decimal Amount {get; private set;}
    public DateTime Date {get; private set;}
    public DateTime ExpirationDate {get; private set;}
    public int ApppointmentId {get; private set;}

    public Payment(int id, decimal amount, DateTime date, DateTime expirationDate, int apppointmentId)
    {
        Id = id;
        Amount = amount;
        Date = date;
        ExpirationDate = expirationDate;
        ApppointmentId = apppointmentId;
    }
}