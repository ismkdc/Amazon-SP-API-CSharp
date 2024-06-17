﻿using FikaAmazonAPI.AmazonSpApiSDK.Models.Token;
using FikaAmazonAPI.AmazonSpApiSDK.Services;
using FikaAmazonAPI.Parameter;
using FikaAmazonAPI.Parameter.Order;
using FikaAmazonAPI.Utils;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.SampleCode;

public class TokenSample
{
    private readonly AmazonConnection amazonConnection;

    public TokenSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }


    public void OrderPII()
    {
        var restrictedResource = new RestrictedResource();
        restrictedResource.method = Method.GET.ToString();
        restrictedResource.path = ApiUrls.OrdersApiUrls.OrderItems("404-7777403-8594716");
        //restrictedResource.dataElements = new List<string> { "buyerInfo", "shippingAddress" };


        var createRDT = new CreateRestrictedDataTokenRequest
        {
            restrictedResources = new List<RestrictedResource> { restrictedResource }
        };

        var parameterBasedPII = new ParameterBasedPII();
        parameterBasedPII.IsNeedRestrictedDataToken = true;
        parameterBasedPII.RestrictedDataTokenRequest = createRDT;

        var order = amazonConnection.Orders.GetOrderItems("404-7777403-8594716", parameterBasedPII);
    }

    public void OrdersPII()
    {
        var restrictedResource = new RestrictedResource();
        restrictedResource.method = Method.GET.ToString();
        restrictedResource.path = ApiUrls.OrdersApiUrls.OrderItems("404-7777403-8594716");
        //restrictedResource.dataElements = new List<string> { "buyerInfo", "shippingAddress" };


        var createRDT = new CreateRestrictedDataTokenRequest
        {
            restrictedResources = new List<RestrictedResource> { restrictedResource }
        };


        var serachOrderList = new ParameterOrderList();
        serachOrderList.CreatedAfter = DateTime.UtcNow.AddHours(-24);
        serachOrderList.OrderStatuses = new List<OrderStatuses>();
        serachOrderList.OrderStatuses.Add(OrderStatuses.Unshipped);
        serachOrderList.MarketplaceIds = new List<string> { MarketPlace.UnitedArabEmirates.ID };
        serachOrderList.RestrictedDataTokenRequest = createRDT;
        serachOrderList.IsNeedRestrictedDataToken = true;

        var orders = amazonConnection.Orders.GetOrders(serachOrderList);
    }
}