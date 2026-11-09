using Day2DesignPattern.Models;
using Day2DesignPattern.Enums;

namespace Day2DesignPattern.Interfaces
{
    public interface IPaymentService
    {
        PaymentType Type {get;}
        PaymentResult Pay(PaymentRequest paymentRequest);
        
    }
}