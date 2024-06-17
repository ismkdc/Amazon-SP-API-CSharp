using Amazon;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Notifications;
using FikaAmazonAPI.NotificationMessages;
using FikaAmazonAPI.Parameter.Notification;
using static FikaAmazonAPI.Utils.Constants;
using DestinationResourceSpecification =
    FikaAmazonAPI.AmazonSpApiSDK.Models.Notifications.DestinationResourceSpecification;
using EventBridgeResourceSpecification =
    FikaAmazonAPI.AmazonSpApiSDK.Models.Notifications.EventBridgeResourceSpecification;
using SqsResource = FikaAmazonAPI.AmazonSpApiSDK.Models.Notifications.SqsResource;

namespace FikaAmazonAPI.SampleCode;

public class NotificationsSample
{
    private readonly AmazonConnection amazonConnection;

    public NotificationsSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }


    public void GetSubscription()
    {
        var data = amazonConnection.Notification.GetSubscription(NotificationType.ANY_OFFER_CHANGED);
    }

    public void GetDestinations()
    {
        var data = amazonConnection.Notification.GetDestinations();
    }


    public void DeleteDestination()
    {
        var data = amazonConnection.Notification.DeleteDestination("99999999-999-4699-999-9999999999999");
    }


    public void CreateDestination()
    {
        //EventBridge
        var data = amazonConnection.Notification.CreateDestination(new CreateDestinationRequest
        {
            Name = "CompanyName",
            ResourceSpecification = new DestinationResourceSpecification
            {
                EventBridge = new EventBridgeResourceSpecification("us-east-2", "999999999")
            }
        });

        //SQS
        var dataSqs = amazonConnection.Notification.CreateDestination(new CreateDestinationRequest
        {
            Name = "CompanyName_AE",
            ResourceSpecification = new DestinationResourceSpecification
            {
                Sqs = new SqsResource("arn:aws:sqs:us-east-2:9999999999999:NAME")
            }
        });
    }


    public void CreateSubscription()
    {
        //SQS
        var result = amazonConnection.Notification.CreateSubscription(
            new ParameterCreateSubscription
            {
                destinationId = "xxxxxxxxxxxxxxx", // take this from CreateDestination or GetDestinations response 
                notificationType = NotificationType.ANY_OFFER_CHANGED, // or B2B_ANY_OFFER_CHANGED for B2B prices
                payloadVersion = "1.0"
            });
    }


    public void StartReceivingNotificationMessages()
    {
        var SQL_URL = "https://sqs.us-east-2.amazonaws.com/239917024027/ICANL_SQS";
        var param = new ParameterMessageReceiver(Environment.GetEnvironmentVariable("AccessKey"),
            Environment.GetEnvironmentVariable("SecretKey"), SQL_URL, RegionEndpoint.USEast2);

        var messageReceiver = new CustomMessageReceiver();


        amazonConnection.Notification.StartReceivingNotificationMessages(param, messageReceiver);
    }

    public class CustomMessageReceiver : IMessageReceiver
    {
        public void ErrorCatch(Exception ex)
        {
            //Your code here
        }

        public void NewMessageRevicedTriger(NotificationMessageResponce message)
        {
            //Your Code here
        }
    }
}