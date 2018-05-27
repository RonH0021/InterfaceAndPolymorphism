using System;
using System.Collections.Generic;

namespace InterfaceAndPolymorphism
{
    public class VideoEncoder
    {
        //private readonly INotificationChannel _notificaitonChannel;
        private readonly IList<INotificationChannel> _notificationChannelList;

        public VideoEncoder()
        {
            _notificationChannelList = new List<INotificationChannel>();
        }

        public void Encode()
        {
            // Video Encoding Logic
           foreach(var channel in _notificationChannelList)
            {
                channel.SendMessage(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannelList.Add(channel);
        }
    }
}
