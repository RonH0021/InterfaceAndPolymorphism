using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();
            videoEncoder.RegisterNotificationChannel(new EmaiNotificationChannel());
            videoEncoder.RegisterNotificationChannel(new SmsNotificationChannel());
            videoEncoder.Encode();
        }
    }
}
