using Day2DesignPattern.Interfaces;
using Day2DesignPattern.Models;
using Day2DesignPattern.Enums;

namespace Day2DesignPattern.Services
{
    public class CarteBancairePaymentService: IPaymentService
    {
        public PaymentType Type => PaymentType.CarteBancaire;

        public PaymentResult Pay(PaymentRequest paymentRequest)
        {
            Console.WriteLine($"Processing payment of {paymentRequest.Amount} by card for {paymentRequest.Titulaire}");

            return new PaymentResult
            {
                Success = true,
                Message = $"Payment by card of {paymentRequest.Amount} sucessful"
            };
        }
    }
}