﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Web.Areas.KAM.Models
{
    public class OperationIntViewModel
    {
        public OperationViewModel OperationViewModel { get; set; }
        public OperationQuoteViewModel OperationQuoteViewModel { get; set; }
        public OperationBookingMessageViewModel OperationBookingMessageViewModel { get; set; }
        public OperationCargoViewModel OperationCargoViewModel { get; set; }
    }
}