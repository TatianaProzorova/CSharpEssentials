using System;

namespace CSharpEssentials
{
    public class ProductDb
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }
    }
}
