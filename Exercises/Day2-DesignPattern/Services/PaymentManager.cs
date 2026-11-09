using Day2DesignPattern.Models;
using Day2DesignPattern.Interfaces;

namespace Day2DesignPattern.Services
{
    public class PaymentManager
    {
        private readonly PaymentFactory _paymentFactory;

        public PaymentManager(PaymentFactory paymentFactory)
        {
            _paymentFactory = paymentFactory;
        }

        public void Pay(PaymentRequest paymentRequest)
        {
            IPaymentService paymentService = _paymentFactory.GetPaymentMethod(paymentRequest.PaymentMethod);
            PaymentResult result = paymentService.Pay(paymentRequest);
        }
    }
}