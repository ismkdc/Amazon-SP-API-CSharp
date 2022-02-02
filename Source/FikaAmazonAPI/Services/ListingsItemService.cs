﻿using System;
using System.Collections.Generic;
using System.Text;
using FikaAmazonAPI.AmazonSpApiSDK.Models.ListingsItems;
using FikaAmazonAPI.Parameter.ListingItem;
using FikaAmazonAPI.Parameter.ListingsItems;
using FikaAmazonAPI.Utils;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Services
{
    public class ListingsItemService : RequestService
    {
        public ListingsItemService(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }

        public Item GetListingsItem(string sellerId, string sku, ParameterGetListingsItem listingsItemParameters)
        {
            if (string.IsNullOrEmpty(sellerId))
                throw new ArgumentException($"'{nameof(sellerId)}' cannot be null or empty.", nameof(sellerId));

            if (string.IsNullOrEmpty(sku))
                throw new ArgumentException($"'{nameof(sku)}' cannot be null or empty.", nameof(sku));

            if (listingsItemParameters.includedData is null)
            {
                listingsItemParameters.includedData = new List<ListingsIncludedData>();
                listingsItemParameters.includedData.Add(ListingsIncludedData.Summaries);
            }
            if (listingsItemParameters.includedData.Count == 0)
                listingsItemParameters.includedData.Add(ListingsIncludedData.Summaries);
            var queryParameters = listingsItemParameters.getParameters();
            CreateAuthorizedRequest(ListingsItemsApiUrls.GetListingItem(sellerId, sku), RestSharp.Method.GET, queryParameters, parameter: listingsItemParameters);
            var response = ExecuteRequest<Item>();

            return response;
        }

        public ListingsItemSubmissionResponse PutListingsItem(ParameterPutListingItem parameterPutListingItem)
        {
            parameterPutListingItem.Check();
            var queryParameters = parameterPutListingItem.getParameters();
            CreateAuthorizedRequest(ListingsItemsApiUrls.PutListingItem(parameterPutListingItem.sellerId, parameterPutListingItem.sku), RestSharp.Method.PUT, postJsonObj: parameterPutListingItem.listingsItemPutRequest, queryParameters: queryParameters);
            var response = ExecuteRequest<ListingsItemSubmissionResponse>();
            return response;
        }

        public ListingsItemSubmissionResponse DeleteListingsItem(ParameterDeleteListingItem parameterDeleteListingItem)
        {
            parameterDeleteListingItem.Check();
            var queryParameters = parameterDeleteListingItem.getParameters();
            CreateAuthorizedRequest(ListingsItemsApiUrls.DeleteListingItem(parameterDeleteListingItem.sellerId, parameterDeleteListingItem.sku), RestSharp.Method.DELETE, queryParameters: queryParameters);
            var response = ExecuteRequest<ListingsItemSubmissionResponse>();
            return response;
        }

        public ListingsItemSubmissionResponse PatchListingsItem(ParameterPatchListingItem parameterPatchListingItem)
        {
            parameterPatchListingItem.Check();
            var queryParameters = parameterPatchListingItem.getParameters();
            CreateAuthorizedRequest(ListingsItemsApiUrls.PatchListingItem(parameterPatchListingItem.sellerId, parameterPatchListingItem.sku), RestSharp.Method.PATCH, queryParameters: queryParameters, postJsonObj: parameterPatchListingItem.listingsItemPatchRequest);
            var response = ExecuteRequest<ListingsItemSubmissionResponse>();
            return response;
        }
    }
}
