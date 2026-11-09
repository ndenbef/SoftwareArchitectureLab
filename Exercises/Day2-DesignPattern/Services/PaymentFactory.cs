using Day2DesignPattern.Models;
using Day2DesignPattern.Enums;
using Day2DesignPattern.Interfaces;

namespace Day2DesignPattern.Services
{
    public class PaymentFactory
    {
        private readonly IEnumerable<IPaymentService> _paymentServices;

        public PaymentFactory(IEnumerable<IPaymentService> paymentServices)
        {
            _paymentServices = paymentServices;
        }

        public IPaymentService GetPaymentMethod(PaymentType paymenttype)
        {
            var paymentService = _paymentServices.FirstOrDefault(p => p.Type == paymenttype);
            if (paymentService == null)
            {
                throw new Exception($"Payment service for {paymenttype} not found.");
            }
            
            return paymentService;
        }
    }
}