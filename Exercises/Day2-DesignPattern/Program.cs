using Microsoft.Extensions.DependencyInjection;
using Day2DesignPattern.Interfaces;
using Day2DesignPattern.Services;
using Day2DesignPattern.Models;
using Day2DesignPattern.Enums;

var services = new ServiceCollection();

services.AddTransient<IPaymentService, MobileMoneyPaymentService>();
services.AddTransient<IPaymentService, VirementBancairePaymentService>();
services.AddTransient<IPaymentService, CarteBancairePaymentService>();
services.AddTransient<IPaymentService, WhatsAppPaymentService>();

services.AddTransient<PaymentManager>();
services.AddTransient<PaymentFactory>();

var serviceProvider = services.BuildServiceProvider();

var paymentManager = serviceProvider.GetRequiredService<PaymentManager>();


paymentManager.Pay(new PaymentRequest { PaymentMethod = PaymentType.Whatsapp, Titulaire = "699999999", Amount = 100m });