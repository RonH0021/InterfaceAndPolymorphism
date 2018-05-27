namespace InterfaceAndPolymorphism
{
    public class EmaiNotificationChannel : INotificationChannel
    {
        public void SendMessage(Message message)
        {
            System.Console.WriteLine("Sending Email...");
        }
    }
}
