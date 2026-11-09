using Day2DesignPattern.Models;
using Day2DesignPattern.Interfaces;
using Day2DesignPattern.Enums;

namespace Day2DesignPattern.Services
{
    public class VirementBancairePaymentService: IPaymentService
    {
        public PaymentType Type => PaymentType.Virement;
        public PaymentResult Pay(PaymentRequest paymentRequest)
        {
            Console.WriteLine($"Processing payment of {paymentRequest.Amount} by bank transfer for {paymentRequest.Titulaire}");

            return new PaymentResult
            {
                Success = true,
                Message = $"Bank transfer of {paymentRequest.Amount} by {paymentRequest.Titulaire} successful"
            };
        }
    }
}