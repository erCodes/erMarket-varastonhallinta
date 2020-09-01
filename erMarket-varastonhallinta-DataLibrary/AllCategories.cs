using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_DataLibrary
{
    public class AllCategories
    {
        public static List<ProductCategory> GetProductCategories()
        {
            List<ProductCategory> categories = new List<ProductCategory>
            {
                new ProductCategory
                {
                    Id = 0,
                    Name = "Groceries"
                },

                new ProductCategory
                {
                    Id = 1,
                    Name = "Vegetables"
                },

                new ProductCategory
                {
                    Id = 2,
                    Name = "Fruits"
                },

                new ProductCategory
                {
                    Id = 3,
                    Name = "MeatProducts"
                },

                new ProductCategory
                {
                    Id = 4,
                    Name = "FishProducts"
                },

                new ProductCategory
                {
                    Id = 5,
                    Name = "DairyProducts"
                },

                new ProductCategory
                {
                    Id = 6,
                    Name = "ReadyMeals"
                },

                new ProductCategory
                {
                    Id = 7,
                    Name = "Drinks"
                },

                new ProductCategory
                {
                    Id = 8,
                    Name = "Preserves"
                },

                new ProductCategory
                {
                    Id = 9,
                    Name = "FrozenFoods"
                },

                new ProductCategory
                {
                    Id = 10,
                    Name = "Tools"
                },

                new ProductCategory
                {
                    Id = 11,
                    Name = "CleaningProducts"
                },

                new ProductCategory
                {
                    Id = 12,
                    Name = "DentalCareProducts"
                }
            };

            return categories;

            //    Groceries,
            //Vegetables,
            //Fruits,
            //MeatProducts,
            //FishProducts,
            //DairyProducts,
            //ReadyMeals,
            //Drinks,
            //Preserves,
            //FrozenFoods,
            //Tools,
            //CleaningProducts,
            //DentalCareProducts
        }
    }
}
