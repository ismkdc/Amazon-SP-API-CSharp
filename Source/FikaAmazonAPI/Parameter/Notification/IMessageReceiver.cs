using System;
using FikaAmazonAPI.NotificationMessages;

namespace FikaAmazonAPI.Parameter.Notification
{
    public interface IMessageReceiver
    {
        void NewMessageRevicedTriger(NotificationMessageResponce message);
        void ErrorCatch(Exception ex);
    }
}