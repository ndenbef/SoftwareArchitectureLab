using Day1Program.Interfaces;

namespace Day1Program.Services
{
    public class NotificationManager
{
    private readonly INotificationService _notificationService;

    public NotificationManager(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void SendNotification(string receiver)
    {
        string message = _notificationService.SendNotification(receiver);
        Console.WriteLine(message);
    }
}
}