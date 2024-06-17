﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound;
using FikaAmazonAPI.Parameter.FulFillmentInbound;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class FulFillmentInboundService : RequestService
    {
        public FulFillmentInboundService(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }

        public GetInboundGuidanceResult GetInboundGuidance(ParameterGetInboundGuidance parameterGetInboundGuidance)
        {
            return Task.Run(() => GetInboundGuidanceAsync(parameterGetInboundGuidance)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<GetInboundGuidanceResult> GetInboundGuidanceAsync(
            ParameterGetInboundGuidance parameterGetInboundGuidance, CancellationToken cancellationToken = default)
        {
            var parameter = parameterGetInboundGuidance.getParameters();
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetInboundGuidance, Method.Get, parameter,
                cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetInboundGuidanceResponse>(
                    RateLimitType.FulFillmentInbound_GetInboundGuidance, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public CreateInboundShipmentPlanResult CreateInboundShipmentPlan(
            CreateInboundShipmentPlanRequest createInboundShipmentPlanRequest)
        {
            return Task.Run(() => CreateInboundShipmentPlanAsync(createInboundShipmentPlanRequest))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CreateInboundShipmentPlanResult> CreateInboundShipmentPlanAsync(
            CreateInboundShipmentPlanRequest createInboundShipmentPlanRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.CreateInboundShipmentPlan, Method.Post,
                postJsonObj: createInboundShipmentPlanRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<CreateInboundShipmentPlanResponse>(
                    RateLimitType.FulFillmentInbound_CreateInboundShipmentPlan, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public InboundShipmentResult UpdateInboundShipment(string shipmentId,
            InboundShipmentRequest inboundShipmentRequest)
        {
            return Task.Run(() => UpdateInboundShipmentAsync(shipmentId, inboundShipmentRequest)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<InboundShipmentResult> UpdateInboundShipmentAsync(string shipmentId,
            InboundShipmentRequest inboundShipmentRequest, CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.UpdateInboundShipment(shipmentId), Method.Put,
                postJsonObj: inboundShipmentRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<InboundShipmentResponse>(
                    RateLimitType.FulFillmentInbound_UpdateInboundShipment, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public InboundShipmentResult CreateInboundShipment(string shipmentId,
            InboundShipmentRequest inboundShipmentRequest)
        {
            return Task.Run(() => CreateInboundShipmentAsync(shipmentId, inboundShipmentRequest)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<InboundShipmentResult> CreateInboundShipmentAsync(string shipmentId,
            InboundShipmentRequest inboundShipmentRequest, CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.CreateInboundShipment(shipmentId), Method.Post,
                postJsonObj: inboundShipmentRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<InboundShipmentResponse>(
                    RateLimitType.FulFillmentInbound_CreateInboundShipment, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public InboundShipmentResult GetPreorderInfo(string shipmentId)
        {
            return Task.Run(() => GetPreorderInfoAsync(shipmentId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<InboundShipmentResult> GetPreorderInfoAsync(string shipmentId,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));

            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetPreorderInfo(shipmentId), Method.Get,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<InboundShipmentResponse>(RateLimitType.FulFillmentInbound_GetPreorderInfo,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public ConfirmPreorderResult ConfirmPreorder(string shipmentId, DateTime NeedByDate)
        {
            return Task.Run(() => ConfirmPreorderAsync(shipmentId, NeedByDate)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<ConfirmPreorderResult> ConfirmPreorderAsync(string shipmentId, DateTime NeedByDate,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));
            queryParameters.Add(new KeyValuePair<string, string>("NeedByDate", NeedByDate.ToString("YYYY-MM-DD")));

            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.ConfirmPreorder(shipmentId), Method.Put,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<ConfirmPreorderResponse>(RateLimitType.FulFillmentInbound_ConfirmPreorder,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetPrepInstructionsResult GetPrepInstructions(ParameterGetPrepInstructions parameterGetPrepInstructions)
        {
            return Task.Run(() => GetPrepInstructionsAsync(parameterGetPrepInstructions)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<GetPrepInstructionsResult> GetPrepInstructionsAsync(
            ParameterGetPrepInstructions parameterGetPrepInstructions, CancellationToken cancellationToken = default)
        {
            var parameter = parameterGetPrepInstructions.getParameters();
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetPrepInstructions, Method.Get, parameter,
                cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetPrepInstructionsResponse>(
                    RateLimitType.FulFillmentInbound_GetPrepInstructions, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetTransportDetailsResult GetTransportDetails(string shipmentId)
        {
            return Task.Run(() => GetTransportDetailsAsync(shipmentId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetTransportDetailsResult> GetTransportDetailsAsync(string shipmentId,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));

            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetTransportDetails(shipmentId), Method.Get,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetTransportDetailsResponse>(
                    RateLimitType.FulFillmentInbound_GetTransportDetails, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public CommonTransportResult PutTransportDetails(string shipmentId,
            PutTransportDetailsRequest putTransportDetailsRequest)
        {
            return Task.Run(() => PutTransportDetailsAsync(shipmentId, putTransportDetailsRequest))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CommonTransportResult> PutTransportDetailsAsync(string shipmentId,
            PutTransportDetailsRequest putTransportDetailsRequest, CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.PutTransportDetails(shipmentId), Method.Put,
                postJsonObj: putTransportDetailsRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<PutTransportDetailsResponse>(
                    RateLimitType.FulFillmentInbound_PutTransportDetails, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public CommonTransportResult VoidTransport(string shipmentId)
        {
            return Task.Run(() => VoidTransportAsync(shipmentId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CommonTransportResult> VoidTransportAsync(string shipmentId,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));

            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.VoidTransport(shipmentId), Method.Post,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<VoidTransportResponse>(RateLimitType.FulFillmentInbound_VoidTransport,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public CommonTransportResult EstimateTransport(string shipmentId)
        {
            return Task.Run(() => EstimateTransportAsync(shipmentId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CommonTransportResult> EstimateTransportAsync(string shipmentId,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));

            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.EstimateTransport(shipmentId), Method.Post,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<EstimateTransportResponse>(RateLimitType.FulFillmentInbound_EstimateTransport,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public CommonTransportResult ConfirmTransport(string shipmentId)
        {
            return Task.Run(() => ConfirmTransportAsync(shipmentId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CommonTransportResult> ConfirmTransportAsync(string shipmentId,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));

            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.ConfirmTransport(shipmentId), Method.Post,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<ConfirmTransportResponse>(RateLimitType.FulFillmentInbound_ConfirmTransport,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public LabelDownloadURL GetLabels(ParameterGetLabels parameterGetLabels)
        {
            return Task.Run(() => GetLabelsAsync(parameterGetLabels)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<LabelDownloadURL> GetLabelsAsync(ParameterGetLabels parameterGetLabels,
            CancellationToken cancellationToken = default)
        {
            var parameter = parameterGetLabels.getParameters();
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetLabels(parameterGetLabels.shipmentId),
                Method.Get, parameter, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetLabelsResponse>(RateLimitType.FulFillmentInbound_GetLabels,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public BillOfLadingDownloadURL GetBillOfLading(string shipmentId)
        {
            return Task.Run(() => GetBillOfLadingAsync(shipmentId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<BillOfLadingDownloadURL> GetBillOfLadingAsync(string shipmentId,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));

            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetBillOfLading(shipmentId), Method.Get,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetBillOfLadingResponse>(RateLimitType.FulFillmentInbound_GetBillOfLading,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetShipmentsResult GetShipments(ParameterGetShipments parameterGetLabels)
        {
            return Task.Run(() => GetShipmentsAsync(parameterGetLabels)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetShipmentsResult> GetShipmentsAsync(ParameterGetShipments parameterGetLabels,
            CancellationToken cancellationToken = default)
        {
            var parameter = parameterGetLabels.getParameters();
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetShipments, Method.Get, parameter,
                cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetShipmentsResponse>(RateLimitType.FulFillmentInbound_GetShipments,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetShipmentItemsResult GetShipmentItemsByShipmentId(string shipmentId)
        {
            return Task.Run(() => GetShipmentItemsByShipmentIdAsync(shipmentId)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<GetShipmentItemsResult> GetShipmentItemsByShipmentIdAsync(string shipmentId,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));

            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetShipmentItemsByShipmentId(shipmentId),
                Method.Get, queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetShipmentItemsResponse>(
                    RateLimitType.FulFillmentInbound_GetShipmentItemsByShipmentId, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public InboundShipmentItemList GetShipmentItems(ParameterGetShipmentItems parameterShipmentItems)
        {
            return Task.Run(() => GetShipmentItemsAsync(parameterShipmentItems)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<InboundShipmentItemList> GetShipmentItemsAsync(
            ParameterGetShipmentItems parameterShipmentItems, CancellationToken cancellationToken = default)
        {
            var inboundShipmentItemList = new InboundShipmentItemList();

            var parameter = parameterShipmentItems.getParameters();
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetShipmentItems, Method.Get, parameter,
                cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetShipmentItemsResponse>(RateLimitType.FulFillmentInbound_GetShipmentItems,
                    cancellationToken);

            var nextToken = response.Payload?.NextToken;
            inboundShipmentItemList = response.Payload?.ItemData;
            var PageCount = 1;

            if (parameterShipmentItems.MaxNumberOfPages.HasValue && parameterShipmentItems.MaxNumberOfPages.Value == 1)
                inboundShipmentItemList.NextToken = nextToken;
            else
                while (!string.IsNullOrEmpty(nextToken))
                {
                    var orderPayload =
                        await GetShipmentItemsByNextTokenAsync(nextToken, parameterShipmentItems, cancellationToken);
                    inboundShipmentItemList.AddRange(orderPayload.ItemData);

                    nextToken = orderPayload.NextToken;
                    inboundShipmentItemList.NextToken = nextToken;

                    if (parameterShipmentItems.MaxNumberOfPages.HasValue)
                    {
                        PageCount++;
                        if (PageCount >= parameterShipmentItems.MaxNumberOfPages.Value)
                            break;
                    }
                }


            return inboundShipmentItemList;
        }

        public async Task<GetShipmentItemsResult> GetShipmentItemsByNextTokenAsync(string nextToken,
            ParameterGetShipmentItems parameterShipmentItems, CancellationToken cancellationToken = default)
        {
            parameterShipmentItems.NextToken = nextToken;
            parameterShipmentItems.QueryType = Constants.QueryType.NEXT_TOKEN;
            parameterShipmentItems.LastUpdatedBefore = null;
            parameterShipmentItems.LastUpdatedAfter = null;

            var parameter = parameterShipmentItems.getParameters();
            await CreateAuthorizedRequestAsync(FulFillmentInboundApiUrls.GetShipmentItems, Method.Get, parameter,
                cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetShipmentItemsResponse>(RateLimitType.FulFillmentInbound_GetShipmentItems,
                    cancellationToken);

            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }
    }
}