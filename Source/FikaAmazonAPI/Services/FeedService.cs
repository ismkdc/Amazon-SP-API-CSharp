using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Exceptions;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Feeds;
using FikaAmazonAPI.ConstructFeed;
using FikaAmazonAPI.ConstructFeed.Messages;
using FikaAmazonAPI.Parameter.Feed;
using FikaAmazonAPI.Utils;
using RestSharp;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Services
{
    public class FeedService : RequestService
    {
        public FeedService(AmazonCredential amazonCredential, IHttpClientFactory httpClientFactory) : base(
            amazonCredential, httpClientFactory)
        {
        }

        public IList<Feed> GetFeeds(ParameterGetFeed parameterGetFeed)
        {
            return Task.Run(() => GetFeedsAsync(parameterGetFeed)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<IList<Feed>> GetFeedsAsync(ParameterGetFeed parameterGetFeed,
            CancellationToken cancellationToken = default)
        {
            var list = new List<Feed>();

            var parameter = parameterGetFeed.getParameters();

            await CreateAuthorizedRequestAsync(FeedsApiUrls.GetFeeds, Method.Get, parameter,
                cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<GetFeedsResponseV00>(RateLimitType.Feed_GetFeeds, cancellationToken);

            list.AddRange(response.Feeds);
            var nextToken = response.NextToken;

            while (!string.IsNullOrEmpty(nextToken))
            {
                var data = await GetFeedsByNextTokenAsync(nextToken, cancellationToken);
                list.AddRange(data.Feeds);
                nextToken = data.NextToken;
            }

            return list;
        }

        public GetFeedsResponseV00 GetFeedsByNextToken(string nextToken)
        {
            return Task.Run(() => GetFeedsByNextTokenAsync(nextToken)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetFeedsResponseV00> GetFeedsByNextTokenAsync(string nextToken,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("nextToken", nextToken));


            await CreateAuthorizedRequestAsync(FeedsApiUrls.GetFeeds, Method.Get, queryParameters,
                cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<GetFeedsResponseV00>(RateLimitType.Feed_GetFeeds, cancellationToken);
            return response;
        }

        public CreateFeedResult CreateFeed(CreateFeedSpecification createFeedSpecification)
        {
            return Task.Run(() => CreateFeedAsync(createFeedSpecification)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<CreateFeedResult> CreateFeedAsync(CreateFeedSpecification createFeedSpecification,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FeedsApiUrls.CreateFeed, Method.Post,
                postJsonObj: createFeedSpecification, cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<CreateFeedResult>(RateLimitType.Feed_CreateFeed, cancellationToken);

            return response;
        }

        public Feed GetFeed(string feedId)
        {
            return Task.Run(() => GetFeedAsync(feedId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Feed> GetFeedAsync(string feedId, CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FeedsApiUrls.GetFeed(feedId), Method.Get,
                cancellationToken: cancellationToken);
            var response = await ExecuteRequestAsync<Feed>(RateLimitType.Feed_GetFeed, cancellationToken);
            if (response != null)
                return response;
            return null;
        }

        public Feed CancelFeed(string feedId)
        {
            return Task.Run(() => CancelFeedAsync(feedId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Feed> CancelFeedAsync(string feedId, CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FeedsApiUrls.CancelFeed(feedId), Method.Delete,
                cancellationToken: cancellationToken);
            var response = await ExecuteRequestAsync<Feed>(RateLimitType.Feed_CancelFeed, cancellationToken);
            if (response != null)
                return response;
            return null;
        }

        public FeedDocument GetFeedDocument(string feedDocumentId)
        {
            return Task.Run(() => GetFeedDocumentAsync(feedDocumentId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<FeedDocument> GetFeedDocumentAsync(string feedDocumentId,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FeedsApiUrls.GetFeedDocument(feedDocumentId), Method.Get,
                cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<FeedDocument>(RateLimitType.Feed_GetFeedDocument, cancellationToken);
            if (response != null)
                return response;
            return null;
        }

        [Obsolete("Use GetFeedDocumentProcessingReportAsync as it handles compressed responses.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ProcessingReportMessage GetFeedDocumentProcessingReport(string url)
        {
            return Task.Run(() => GetFeedDocumentProcessingReportAsync(url)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public async Task<ProcessingReportMessage> GetFeedDocumentProcessingReportAsync(string url)
        {
            ProcessingReportMessage processingReport = null;
            string responseContent;
            var stream = await GetStreamFromUrlAsync(url);
            var xmlSerializer = new XmlSerializer(typeof(FeedAmazonEnvelope));
            FeedAmazonEnvelope response = null;

            try
            {
                response = (FeedAmazonEnvelope)xmlSerializer.Deserialize(stream);
            }
            catch (Exception e)
            {
                var reader = new StreamReader(stream);
                responseContent = reader.ReadToEnd();
                throw new AmazonProcessingReportDeserializeException(
                    "Something went wrong on deserialize report stream", responseContent);
            }

            processingReport = response.Message[0].ProcessingReport;
            return processingReport;
        }

        public ProcessingReportMessage GetFeedDocumentProcessingReport(FeedDocument feedDocument)
        {
            return Task.Run(() => GetFeedDocumentProcessingReportAsync(feedDocument)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<ProcessingReportMessage> GetFeedDocumentProcessingReportAsync(FeedDocument feedDocument,
            CancellationToken cancellationToken = default)
        {
            ProcessingReportMessage processingReport = null;
            string responseContent;
            var stream = await GetStreamFromUrlAsync(feedDocument.Url, cancellationToken);
            if (feedDocument.CompressionAlgorithm.HasValue && feedDocument.CompressionAlgorithm.Value ==
                FeedDocument.CompressionAlgorithmEnum.GZIP)
                stream = new GZipStream(stream, CompressionMode.Decompress);
            var xmlSerializer = new XmlSerializer(typeof(FeedAmazonEnvelope));
            FeedAmazonEnvelope response = null;

            try
            {
                response = (FeedAmazonEnvelope)xmlSerializer.Deserialize(stream);
            }
            catch (Exception e)
            {
                var reader = new StreamReader(stream);
                responseContent = await reader.ReadToEndAsync();
                throw new AmazonProcessingReportDeserializeException(
                    "Something went wrong on deserialize report stream", responseContent);
            }

            processingReport = response.Message[0].ProcessingReport;
            return processingReport;
        }

        public CreateFeedDocumentResult CreateFeedDocument(Constants.ContentType contentType)
        {
            return Task.Run(() => CreateFeedDocumentAsync(contentType)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CreateFeedDocumentResult> CreateFeedDocumentAsync(Constants.ContentType contentType,
            CancellationToken cancellationToken = default)
        {
            var contxt = contentType.GetEnumMemberValue();
            var createFeedDocumentSpecification = new CreateFeedDocumentSpecification(contxt);

            await CreateAuthorizedRequestAsync(FeedsApiUrls.CreateFeedDocument, Method.Post,
                postJsonObj: createFeedDocumentSpecification, cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<CreateFeedDocumentResult>(RateLimitType.Feed_CreateFeedDocument,
                    cancellationToken);
            if (response != null)
                return response;
            return null;
        }

        public string SubmitFeedFile(string FilePath, FeedType feedType, List<string> marketPlaceIds = null,
            FeedOptions feedOptions = null, Constants.ContentType contentType = Constants.ContentType.XML)
        {
            return Task.Run(() =>
                    SubmitFeedAsync(FilePath, feedType, marketPlaceIds, feedOptions, contentType, ContentFormate.File))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<string> SubmitFeedFileAsync(string FilePath, FeedType feedType,
            List<string> marketPlaceIds = null, FeedOptions feedOptions = null,
            Constants.ContentType contentType = Constants.ContentType.XML,
            CancellationToken cancellationToken = default)
        {
            return await SubmitFeedAsync(FilePath, feedType, marketPlaceIds, feedOptions, contentType,
                ContentFormate.File, cancellationToken);
        }

        public string SubmitFeedContent(string Content, FeedType feedType, List<string> marketPlaceIds = null,
            FeedOptions feedOptions = null, Constants.ContentType contentType = Constants.ContentType.XML)
        {
            return Task.Run(() =>
                    SubmitFeedAsync(Content, feedType, marketPlaceIds, feedOptions, contentType, ContentFormate.Text))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<string> SubmitFeedContentAsync(string Content, FeedType feedType,
            List<string> marketPlaceIds = null, FeedOptions feedOptions = null,
            Constants.ContentType contentType = Constants.ContentType.XML,
            CancellationToken cancellationToken = default)
        {
            return await SubmitFeedAsync(Content, feedType, marketPlaceIds, feedOptions, contentType,
                ContentFormate.Text, cancellationToken);
        }

        public string SubmitFeed(string XmlContentOrFilePath, FeedType feedType, List<string> marketPlaceIds = null,
            FeedOptions feedOptions = null, Constants.ContentType contentType = Constants.ContentType.XML,
            ContentFormate contentFormate = ContentFormate.AutoDetect)
        {
            return Task.Run(() => SubmitFeedAsync(XmlContentOrFilePath, feedType, marketPlaceIds, feedOptions,
                contentType, contentFormate)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///     read full step
        ///     https://github.com/amzn/selling-partner-api-docs/blob/main/guides/en-US/use-case-guides/feeds-api-use-case-guide/feeds-api-use-case-guide_2021-06-30.md
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="feedType"></param>
        /// <returns></returns>
        public async Task<string> SubmitFeedAsync(string feedContentOrFilePath, FeedType feedType,
            List<string> marketPlaceIds = null, FeedOptions feedOptions = null,
            Constants.ContentType contentType = Constants.ContentType.XML,
            ContentFormate contentFormate = ContentFormate.AutoDetect, CancellationToken cancellationToken = default)
        {
            //We are creating Feed Document
            var feedCreate = await CreateFeedDocumentAsync(contentType, cancellationToken);

            //Uploading encoded invoice file
            _ = await PostFileDataAsync(feedCreate.Url, feedContentOrFilePath, contentType, contentFormate,
                cancellationToken);

            var createFeedSpecification = new CreateFeedSpecification
            {
                FeedType = feedType.ToString(),
                InputFeedDocumentId = feedCreate.FeedDocumentId,
                MarketplaceIds = marketPlaceIds ?? new List<string> { AmazonCredential.MarketPlace.ID },
                FeedOptions = feedOptions
            };

            //Submit XML
            var feed = await CreateFeedAsync(createFeedSpecification, cancellationToken);

            return feed.FeedId;
        }

        private static async Task<Stream> GetStreamFromUrlAsync(string url,
            CancellationToken cancellationToken = default)
        {
            byte[] imageData = null;

            using (var wc = new WebClient())
            {
                imageData = await wc.DownloadDataTaskAsync(new Uri(url));
            }

            return new MemoryStream(imageData);
        }

        private async Task<string> PostFileDataAsync(string destinationUrl, string contentOrFilePath,
            Constants.ContentType contentType = Constants.ContentType.XML,
            ContentFormate contentFormate = ContentFormate.AutoDetect, CancellationToken cancellationToken = default)
        {
            var request = (HttpWebRequest)WebRequest.Create(destinationUrl);

            byte[] bytes = null;
            if (contentFormate == ContentFormate.File)
            {
                bytes = File.ReadAllBytes(contentOrFilePath);
            }
            else if (contentFormate == ContentFormate.Text)
            {
                bytes = Encoding.UTF8.GetBytes(contentOrFilePath);
            }
            else if (contentFormate == ContentFormate.AutoDetect)
            {
                if (IsPathRooted(contentOrFilePath))
                {
                    // The string looks like a file path, so try to read the file
                    if (File.Exists(contentOrFilePath))
                        bytes = File.ReadAllBytes(contentOrFilePath);
                    else
                        throw new AmazonException("Feed File not exist");
                }
                else
                {
                    // The file does not exist, so treat the string as content
                    bytes = Encoding.UTF8.GetBytes(contentOrFilePath);
                }
            }

            request.ContentType = contentType.GetEnumMemberValue();
            request.ContentLength = bytes.Length;
            request.Method = "PUT";
            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                var response = (HttpWebResponse)await request.GetResponseAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseStream = response.GetResponseStream();
                    var responseStr = await new StreamReader(responseStream).ReadToEndAsync();
                    return responseStr;
                }
            }

            return null;
        }

        private bool IsPathRooted(string content)
        {
            if (string.IsNullOrEmpty(content))
                return false;

            if (content.Length > 255 || content.Contains("\n"))
                return false;

            return true;
        }
    }
}