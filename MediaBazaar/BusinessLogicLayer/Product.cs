using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Product
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public decimal Weight { get; private set; }
        public decimal Height { get; private set; }
        public decimal Width { get; private set; }
        public decimal Depth { get; private set; }
        public ProductCategoryEum Category { get; private set; }

        public Product(int id, string model, string brand, decimal price, string description, decimal weight, decimal height, decimal width, decimal depth, ProductCategoryEum category)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Price = price;
            Description = description;
            Weight = weight;
            Height = height;
            Width = width;
            Depth = depth;
            Category = category;
        }

        public void UpdateProduct(string model, string brand, decimal price, string description, decimal weight, decimal height, decimal width, decimal depth, ProductCategoryEum category)
        {
            Model = model;
            Brand = brand;
            Price = price;
            Description = description;
            Weight = weight;
            Height = height;
            Width = width;
            Depth = depth;
            Category = category;
        }
    }

}
