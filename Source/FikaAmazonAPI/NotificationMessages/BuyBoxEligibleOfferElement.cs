﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FikaAmazonAPI.NotificationMessages
{
    public partial class BuyBoxEligibleOfferElement
    {
        public string Condition { get; set; }
        public string FulfillmentChannel { get; set; }
        public long OfferCount { get; set; }
    }
}
