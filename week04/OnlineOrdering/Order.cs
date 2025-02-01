using System;
using System.Collections.Generic;

namespace OrderSystem
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.TotalCost();
            }

            decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;
            total += shippingCost;

            return total;
        }

        public string GetPackingLabel()
        {
            var packingLabel = "";
            foreach (var product in _products)
            {
                packingLabel += $"Product: {product.Name}, Product ID: {product.ProductId}\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"Name: {_customer.Name}\n{_customer.CustomerAddress.GetFullAddress()}";
        }
    }
}