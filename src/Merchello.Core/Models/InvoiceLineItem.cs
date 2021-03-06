﻿using System;
using System.Runtime.Serialization;

namespace Merchello.Core.Models
{
    /// <summary>
    /// Represents an invoice line item
    /// </summary>
    /// <remarks>
    /// Needed for typed query mapper
    /// </remarks>
    [Serializable]
    [DataContract(IsReference = true)]
    public class InvoiceLineItem : LineItemBase, IInvoiceLineItem
    {

        public InvoiceLineItem(string name, string sku, decimal amount) 
            : base(name, sku, amount)
        {
        }

        public InvoiceLineItem(string name, string sku, int quantity, decimal amount) 
            : base(name, sku, quantity, amount)
        {
        }

        public InvoiceLineItem(LineItemType lineItemType, string name, string sku, int quantity, decimal price) 
            : base(lineItemType, name, sku, quantity, price)
        {
        }

        public InvoiceLineItem(LineItemType lineItemType, string name, string sku, int quantity, decimal price, ExtendedDataCollection extendedData) 
            : base(lineItemType, name, sku, quantity, price, extendedData)
        {
        }

        public InvoiceLineItem(Guid lineItemTfKey, string name, string sku, int quantity, decimal price, ExtendedDataCollection extendedData) 
            : base(lineItemTfKey, name, sku, quantity, price, extendedData)
        {
        }
    }
}