﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GameStore.Models
{
    public class Cart
    {
        public List<CartLine>? Lines { get; set; } = new List<CartLine>();

        public void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines
                .Where(p => p.Product.ProductId == product.ProductId)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product) =>
            Lines.RemoveAll(l => l.Product.ProductId == product.ProductId);

        public decimal ComputeTotalValue() => Lines.Sum(e => e.Product.Price * e.Quantity);

        public void Clear() => Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        
    }

}
