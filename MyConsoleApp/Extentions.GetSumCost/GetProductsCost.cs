using System.Collections.Generic;

namespace CSharpEssentials
{
    public static class GetProductsCost
    {
        public static decimal GetSumCost(this List<Product> products)
        {
            decimal sum = 0;
            foreach (var product in products)
            {
                sum += product.Cost;
            }

            return sum;
        }
    }
}
