using Day2DesignPattern.Enums;

namespace Day2DesignPattern.Models
{
    public class PaymentRequest
    {
        public PaymentType PaymentMethod {get; set;}
        public string Titulaire {get; set;}
        public decimal Amount {get; set;}
    }
}