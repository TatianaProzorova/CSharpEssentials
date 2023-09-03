namespace CSharpEssentials
{
    public static class ProductView
    {
        public static ProductViewModel ToProductViewModel(this ProductDb product)
        {            
            ProductViewModel result = new ProductViewModel();
            result.Id = product.Id;
            result.Name = product.Name;
            result.Cost = product.Cost;

            return result;
        }
        //code from Main()
        //var productDb = new ProductDb()
        //{
        //    Id = Guid.NewGuid(),
        //    Name = "Молоко",
        //    Cost = 120,
        //    Description = "Натуральное молоко из деревни",
        //    ImagePath = "https://lenta.gcdn.co/globalassets/1/-/10/20/65/346818_2.png?preset=fulllossywhite"
        //};

        //ProductViewModel productViewModel = productDb.ToProductViewModel();

        //Console.WriteLine(productViewModel.Name); // Молоко
        //    Console.WriteLine(productViewModel.Cost); // 120
    }
}
