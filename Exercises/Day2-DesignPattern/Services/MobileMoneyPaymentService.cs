using Day2DesignPattern.Models;
using Day2DesignPattern.Enums;
using Day2DesignPattern.Interfaces;

namespace Day2DesignPattern.Services
{
    public class MobileMoneyPaymentService: IPaymentService
    {
        public PaymentType Type => PaymentType.MobileMoney;

        public PaymentResult Pay(PaymentRequest paymentRequest)
        {   
            Console.WriteLine($"Processing mobile payment of {paymentRequest.Amount} by {paymentRequest.Titulaire}");

            return new PaymentResult
            {
                Success = true,
                Message = $"Mobile Payment of {paymentRequest.Amount} by {paymentRequest.Titulaire} sucessful"
            };
        }
    }
}