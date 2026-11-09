using Day2DesignPattern.Models;
using Day2DesignPattern.Enums;
using Day2DesignPattern.Interfaces;

namespace Day2DesignPattern.Services
{
    public class WhatsAppPaymentService: IPaymentService
    {
        public PaymentType Type => PaymentType.Whatsapp;

        public PaymentResult Pay(PaymentRequest paymentRequest)
        {   
            Console.WriteLine($"Processing WhatsApp payment of {paymentRequest.Amount} by {paymentRequest.Titulaire}");

            return new PaymentResult
            {
                Success = true,
                Message = $"WhatsApp Payment of {paymentRequest.Amount} by {paymentRequest.Titulaire} sucessful"
            };
        }
    }
}