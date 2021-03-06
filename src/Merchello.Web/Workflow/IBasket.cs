﻿using System;
using Merchello.Core.Models;

namespace Merchello.Web.Workflow
{
    public interface IBasket
    {
        Guid VersionKey { get; }

        // Adds an item to the basket
        void AddItem(IProduct product);
        void AddItem(IProduct product, int quantity);
        void AddItem(IProduct product, string name, int quantity);
        void AddItem(IProduct product, string name, int quantity, ExtendedDataCollection extendedData);
        void AddItem(IProductVariant productVariant);
        void AddItem(IProductVariant productVariant, int quantity);
        void AddItem(IProductVariant productVariant, string name, int quantity);
        void AddItem(IProductVariant productVariant, string name, int quantity, ExtendedDataCollection extendedData);
        //void AddItem(string name, string sku, decimal price);
        //void AddItem(string name, string sku, int quantity, decimal price);
        //void AddItem(string name, string sku, int quantity, decimal price, ExtendedDataCollection extendedData);

        // Updates the quantity of an item in the basket
        void UpdateQuantity(Guid key, int quantity);
        void UpdateQuantity(string sku, int quantity);
        void UpdateQuantity(IProductVariant productVariant, int quantity);
      
        /// Removes an item from the basket      
        void RemoveItem(Guid itemKey);     
        void RemoveItem(string sku);        
        void RemoveItem(IProductVariant productVariant);

        /// <summary>
        /// True/false indicating whether or not the basket contains any items
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Empties the basket
        /// </summary>
        void Empty();

        /// <summary>
        /// Refreshes cache with database values
        /// </summary>
        void Refresh();

        /// <summary>
        /// Saves the basket
        /// </summary>
        void Save();

        /// <summary>
        /// Accepts visitor class to visit basket items
        /// </summary>
        /// <param name="visitor"><see cref="ILineItemVisitor"/></param>
        void Accept(ILineItemVisitor visitor);

        /// <summary>
        /// The customer assoicated with the basket
        /// </summary>
        ICustomerBase Customer { get; }

        /// <summary>
        /// The basket line items
        /// </summary>
        LineItemCollection Items { get; }

        /// <summary>
        /// Returns the basket's item count
        /// </summary>
        int TotalItemCount { get; }

        /// <summary>
        /// Returns the sum of all basket item quantities
        /// </summary>
        int TotalQuantityCount { get; }

        /// <summary>
        /// Returns the sum of all basket item "amount" multiplied by quantity (price)
        /// </summary>
        decimal TotalBasketPrice { get; }
    }
}