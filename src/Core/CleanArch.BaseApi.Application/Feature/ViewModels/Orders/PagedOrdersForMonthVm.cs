﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.BaseApi.Application.Feature.ViewModels.Orders
{
    public class PagedOrdersForMonthVm
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public ICollection<OrdersForMonthDto> OrdersForMonth { get; set; }
    }
}
