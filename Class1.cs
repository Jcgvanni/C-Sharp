using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01___300295374
{
    class Invoice
    {
        public string PartNumber { get; set; }
        public string PartDesc { get; set; }
        private int Quantity;
        private decimal PricePerItem;

        public Invoice(string partNumber, string partDesc, int quantity, decimal pricePerItem)
        {
            PartNumber = partNumber;
            PartDesc = partDesc;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }

        public int getQuantity
        {
            get { return Quantity;  }
            set
            {
                if (value > 0)
                    Quantity = value;
                else
                    Quantity = 1;
            }
            
        }
        public decimal getUnitPrice
        {
            get { return PricePerItem;  }
            set
            {
                if (value > 0)
                    PricePerItem = value;
                else
                    PricePerItem = 1;
            }

        }
        public decimal GetInvoiceAmount()
        {
            return getQuantity * getUnitPrice;
        }
    }
}
