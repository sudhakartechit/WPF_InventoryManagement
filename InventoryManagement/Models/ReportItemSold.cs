﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    class ReportItemSold
    {
        public int InventoryItemID { get; set; }
        public ItemType ItemType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal QuantityPurchased { get; set; }
        public decimal CostPerItem { get; set; } // in theory, should be an average, as this could change over time
        public Currency CostCurrency { get; set; }

        public string CostWithCurrency
        {
            get
            {
                if (CostCurrency != null)
                {
                    return CostPerItem.ToString() + " (" + CostCurrency?.Symbol + ")";
                }
                return CostPerItem.ToString();
            }
        }

        public decimal TotalCost { get; set; }

        public string TotalCostWithCurrency
        {
            get
            {
                if (CostCurrency != null)
                {
                    return TotalCost.ToString() + " (" + CostCurrency?.Symbol + ")";
                }
                return TotalCost.ToString();
            }
        }

        public decimal ProfitPerItem { get; set; } // in theory, should be an average, as this could change over time
        public Currency ProfitCurrency { get; set; }
        public decimal TotalProfit { get; set; }

        public string ProfitWithCurrency
        {
            get
            {
                if (ProfitCurrency != null)
                {
                    return string.Format("{0:n} ({1})", ProfitPerItem, ProfitCurrency?.Symbol);
                }
                return string.Format("{0:n}", ProfitPerItem);
            }
        }

        public string TotalProfitWithCurrency
        {
            get
            {
                if (ProfitCurrency != null)
                {
                    return string.Format("{0:n} ({1})", TotalProfit, ProfitCurrency?.Symbol);
                }
                return string.Format("{0:n}", TotalProfit);
            }
        }
    }
}
