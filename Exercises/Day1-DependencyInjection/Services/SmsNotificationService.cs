using Day1Program.Interfaces;

namespace Day1Program.Services
{
    public class SmsNotificationService: INotificationService
    {
        public SmsNotificationService()
        {
            
        }

        public string SendNotification(string number)
        {
            return "You got an Sms";
        }
    }
}