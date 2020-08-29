using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_DataLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<Categories> Type { get; set; }
        public int InStock { get; set; }
        public DateTime QuantityChanged { get; set; }

        public Product()
        {
            Type = new List<Categories>();
        }
    }

    public enum Categories
    {
        Groceries,
        Vegetables,
        Fruits,
        MeatProducts,
        FishProducts,
        DairyProducts,
        ReadyMeals,
        Drinks,
        Preserves,
        FrozenFoods,
        Tools,
        CleaningProducts,
        DentalCareProducts
    }
}
