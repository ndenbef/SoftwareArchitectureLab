using Microsoft.Extensions.DependencyInjection;
using Day1Program.Interfaces;
using Day1Program.Services;

var services = new ServiceCollection();

// Enregistrement des dépendances
services.AddTransient<INotificationService, EmailNotificationService>();
services.AddTransient<NotificationManager>();

// Construction du conteneur
var serviceProvider = services.BuildServiceProvider();

// Récupération du NotificationManager
var notificationManager = serviceProvider.GetRequiredService<NotificationManager>();

// Utilisation
notificationManager.SendNotification("user@example.com");