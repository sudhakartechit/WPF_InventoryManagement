﻿using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Interfaces
{
    interface IItemsSoldReportData
    {
        bool IsDailyReport();
        DateTime GetDate();
        List<ReportItemSold> GetItemsSold();
        int GetTotalItemsSold();
        string GetTotalIncomeWithCurrency();
        string GetTotalProfitWithCurrency();
        List<ItemTypeMoneyInfo> GetItemTypeMoneyInfo();
    }
}
