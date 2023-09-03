namespace CSharpEssentials
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }


        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        // code from Main()
        //List<Product> products = new List<Product>
        //    {
        //        new Product("Ноутбук", 6000),
        //        new Product("Мышка", 100),
        //        new Product("Наушники", 300),
        //        new Product("Клавиатура", 200)
        //    };

        //decimal sumCost = products.GetSumCost();
        //Console.WriteLine(sumCost); // 6600
    }
}
