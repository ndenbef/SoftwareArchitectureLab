using Day1Program.Interfaces;

namespace Day1Program.Services
{
    public class EmailNotificationService: INotificationService
    {
        public EmailNotificationService()
        {
            
        }

        public string SendNotification(string email)
        {
            return "You got an E-mail";
        }
    }
}