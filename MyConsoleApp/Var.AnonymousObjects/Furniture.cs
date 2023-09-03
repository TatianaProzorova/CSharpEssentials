namespace CSharpEssentials
{
    public class Furniture
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public bool InStock { get; set; }

        //code from Main()
        //var allFurniture = new List<Furniture>{
        //        new Furniture{
        //            Height = 100,
        //            Width = 50,
        //            Type = "Chair",
        //            Name = "A-234-c",
        //            Manufacturer = "FamousChairManufacturer",
        //            Price = 5000,
        //            InStock = true
        //        },
        //        new Furniture{
        //            Height = 90,
        //            Width = 60,
        //            Type = "Table",
        //            Name = "T-75",
        //            Manufacturer = "YourTables",
        //            Price = 10000,
        //            InStock = true
        //        },
        //        new Furniture{
        //            Height = 80,
        //            Width = 70,
        //            Type = "Sofa",
        //            Name = "S-17-56",
        //            Manufacturer = "NotSoFamousSofaManufacturer",
        //            Price = 15999,
        //            InStock = false
        //        },
        //        new Furniture{
        //            Height = 92,
        //            Width = 100,
        //            Type = "Chair",
        //            Name = "A-238-ch",
        //            Manufacturer = "FamousChairManufacturer",
        //            Price = 6000, InStock = true
        //        },
        //        new Furniture{
        //            Height = 103,
        //            Width = 73,
        //            Type = "Closet",
        //            Name = "C-32-32",
        //            Manufacturer = "ClosetMaker",
        //            Price = 23000,
        //            InStock = true
        //        }
        //    };

        //var closets = new List<object>();
        //    foreach (var furnitureElement in allFurniture)
        //    {
        //        if (furnitureElement.Type == "Closet")
        //        {
        //            var exemplar = new { Height = furnitureElement.Height, Width = furnitureElement.Width };
        //closets.Add(exemplar);
        //        }
        //}
    }
}
