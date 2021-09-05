﻿using FikaAmazonAPI.ConstructFeed;
using FikaAmazonAPI.ConstructFeed.Messages;
using FikaAmazonAPI.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Test
{
    [TestClass]
    public class Feeds
    {
        AmazonConnection amazonConnection;
        public Feeds()
        {
            amazonConnection = new AmazonConnection(new AmazonCredential()
            {
                AccessKey = Environment.GetEnvironmentVariable("AccessKey"),
                SecretKey = Environment.GetEnvironmentVariable("SecretKey"),
                RoleArn = Environment.GetEnvironmentVariable("RoleArn"),
                ClientId = Environment.GetEnvironmentVariable("ClientId"),
                ClientSecret = Environment.GetEnvironmentVariable("ClientSecret"),
                RefreshToken = Environment.GetEnvironmentVariable("RefreshToken"),
                MarketPlace = MarketPlace.UnitedArabEmirates

            });

        }



        [TestMethod]
        public void GetFeeds()
        {

            var data = amazonConnection.Feed.GetFeeds(new Parameter.Feed.ParameterGetFeed()
            {
                processingStatuses = ProcessingStatuses.DONE,
                pageSize = 100,
                feedTypes = new List<FeedType> { FeedType.POST_PRODUCT_PRICING_DATA },
                createdSince = DateTime.UtcNow.AddDays(-6),
                createdUntil = DateTime.UtcNow.AddDays(-1),
                marketplaceIds = new List<string> { MarketPlace.UnitedArabEmirates.ID }
            });
        }

        [TestMethod]
        public void CreateFeedDocument()
        {

            var data = amazonConnection.Feed.CreateFeedDocument(ContentType.XML);
        }


        [TestMethod]
        public void GetFeedDocument()
        {

            var data2 = amazonConnection.Feed.GetFeedDocument("amzn1.tortuga.3.92d8fd38-6ccf-49be-979f-6dc27375ea3e.T2DF7HINJ0NRA2");
        }
        [TestMethod]
        public void GetFeed()
        {

            var data2 = amazonConnection.Feed.GetFeed("194146018872");
        }
        [TestMethod]
        public void CancelFeed()
        {

            var data2 = amazonConnection.Feed.CancelFeed("194146018872");
        }
        [TestMethod]
        public void SubmitFeed()
        {
            ConstructFeedService createDocument = new ConstructFeedService("A3J37AJU4O9RHK", "1.02");
            var list = new List<InventoryMessage>();
            list.Add(new InventoryMessage()
            {
                SKU = "8201031206122...",
                Quantity = 2,
                FulfillmentLatency = "12"
            });
            createDocument.AddInventoryMessage(list);
            var xml = createDocument.GetXML();

            var feedID = amazonConnection.Feed.SubmitFeed(xml, FeedType.POST_INVENTORY_AVAILABILITY_DATA);
        }
        

    }
}
