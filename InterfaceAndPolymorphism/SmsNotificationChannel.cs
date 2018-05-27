namespace InterfaceAndPolymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void SendMessage(Message message)
        {
            System.Console.WriteLine("Sending SMS...");
        }
    }
}
