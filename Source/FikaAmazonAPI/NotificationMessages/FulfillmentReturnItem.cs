﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FikaAmazonAPI.NotificationMessages
{
    public partial class FulfillmentReturnItem
    {
        public EventTime ReceivedDateTime { get; set; }
        public int ReturnedQuantity { get; set; }
        public EventTime SellerSku { get; set; }
    }
}
