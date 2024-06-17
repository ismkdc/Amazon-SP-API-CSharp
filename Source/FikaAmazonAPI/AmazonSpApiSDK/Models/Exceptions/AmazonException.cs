using System;
using System.Net;
using RestSharp;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Exceptions
{
    public class AmazonException : Exception
    {
        public AmazonException(string msg, RestResponse response = null) : base(msg)
        {
            if (response != null)
            {
                Response = new ExceptionResponse();
                Response.Content = response.Content;
                Response.ResponseCode = response.StatusCode;
            }
        }

        public ExceptionResponse Response { get; set; }
    }

    public class AmazonNotFoundException : AmazonException
    {
        public AmazonNotFoundException(string msg, RestResponse response = null) : base(msg, response)
        {
        }
    }

    public class AmazonUnauthorizedException : AmazonException
    {
        public AmazonUnauthorizedException(string msg, RestResponse response = null) : base(msg, response)
        {
        }
    }

    public class AmazonInvalidInputException : AmazonException
    {
        public AmazonInvalidInputException(string msg, string details = null, RestResponse response = null) : base(msg,
            response)
        {
            Details = details;
            //this.Data["Details"] = details;
        }

        public string Details { get; set; }
    }

    public class AmazonQuotaExceededException : AmazonException
    {
        public AmazonQuotaExceededException(string msg, RestResponse response = null) : base(msg, response)
        {
        }
    }

    public class AmazonInvalidSignatureException : AmazonException
    {
        public AmazonInvalidSignatureException(string msg, RestResponse response = null) : base(msg, response)
        {
        }
    }

    public class AmazonInternalErrorException : AmazonException
    {
        public AmazonInternalErrorException(string msg, RestResponse response = null) : base(msg, response)
        {
        }
    }

    public class AmazonBadRequestException : AmazonException
    {
        public AmazonBadRequestException(string msg, RestResponse response = null) : base(msg, response)
        {
        }
    }

    public class AmazonProcessingReportDeserializeException : AmazonException
    {
        public AmazonProcessingReportDeserializeException(string msg, string reportContent,
            RestResponse response = null) : base(msg, response)
        {
            ReportContent = reportContent;
        }

        public string ReportContent { get; set; }
    }

    public class ExceptionResponse
    {
        public string Content { get; set; }
        public HttpStatusCode? ResponseCode { get; set; }
    }
}