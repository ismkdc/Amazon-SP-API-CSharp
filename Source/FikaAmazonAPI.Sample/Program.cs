﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AmazonSpApiSDK.Api.Sellers;
using AmazonSpApiSDK.Clients;
using FikaAmazonAPI;
using FikaAmazonAPI.Parameter;
using FikaAmazonAPI.Parameter.Order;
using FikaAmazonAPI.Parameter.Report;
using FikaAmazonAPI.Utils;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {




            AmazonConnection amazonConnection = new AmazonConnection(new AmazonCredential()
            {
                AccessKey = Environment.GetEnvironmentVariable("AccessKey"),
                SecretKey = Environment.GetEnvironmentVariable("SecretKey"),
                RoleArn = Environment.GetEnvironmentVariable("RoleArn"),
                ClientId = Environment.GetEnvironmentVariable("ClientId"),
                ClientSecret = Environment.GetEnvironmentVariable("ClientSecret"),
                RefreshToken = Environment.GetEnvironmentVariable("RefreshToken"),
                MarketPlace = MarketPlace.UnitedArabEmirates

            });


            //ListFinancialEvents

            amazonConnection.Financial.ListFinancialEvents(new Parameter.Finance.ParameterListFinancialEvents()
            {
                  PostedAfter=DateTime.UtcNow.AddDays(-1),
                  PostedBefore=DateTime.UtcNow.AddDays(-30),
                  MaxResultsPerPage=55
            });


            Console.ReadLine();
            
        }
    }
}
