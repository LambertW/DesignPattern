using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    public sealed class PurchaseRequest
    {
        public decimal Amount { get; set; }

        public string ProductName { get; set; }

        public PurchaseRequest(decimal amount, string productName)
        {
            Amount = amount;
            ProductName = productName;
        }
    }
}
