namespace DTOs.Payment;
using System.ComponentModel.DataAnnotations;

public class EntryPaymentDTO
{
    [Required(ErrorMessage = "Amount is Required")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Date is Required")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Expiration Date is Required")]
    public DateTime ExpirationDate { get; set; }

    [Required(ErrorMessage = "AppointmentId is Required")]
    public int AppointmentId { get; set; }
}