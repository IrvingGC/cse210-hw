using System;

namespace OrderSystem
{
    public class Product
    {
        private string _name;
        private int _productId;
        private decimal _price;
        private int _quantity;

        public Product(string name, int productId, decimal price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        public string Name => _name;
        public int ProductId => _productId;
        public decimal Price => _price;
        public int Quantity => _quantity;

        public decimal TotalCost()
        {
            return _price * _quantity;
        }
    }
}