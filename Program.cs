using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search();
            List<Product> Items = new List<Product>();
            List<Category> Cate = new List<Category>();
            List<Menu> Menu = new List<Menu>();

            //Insert data product
            Items.Add(new Product() { name = "CPU", price = 750, quality = 10, categoryId = 1 });
            Items.Add(new Product() { name = "RAM", price = 50, quality = 2, categoryId = 2 });
            Items.Add(new Product() { name = "HDD", price = 70, quality = 1, categoryId = 2 });
            Items.Add(new Product() { name = "Main", price = 400, quality = 3, categoryId = 1 });
            Items.Add(new Product() { name = "Keyboard", price = 30, quality = 8, categoryId = 4 });
            Items.Add(new Product() { name = "Mouse", price = 25, quality = 50, categoryId = 4 });
            Items.Add(new Product() { name = "VGA", price = 60, quality = 35, categoryId = 3 });
            Items.Add(new Product() { name = "Monitor", price = 120, quality = 28, categoryId = 2 });
            Items.Add(new Product() { name = "Case", price = 120, quality = 28, categoryId = 5 });

            //Insert data category
            Cate.Add(new Category() { id = 1, name = "Computer" });
            Cate.Add(new Category() { id = 2, name = "Memory" });
            Cate.Add(new Category() { id = 3, name = "Card" });
            Cate.Add(new Category() { id = 4, name = "Acsesory" });

            //Search product by name
            Product item = new Product();
            item = search.findProduct(Items, "RAM");
            Console.WriteLine("Get information product have name is RAM:");
            Console.WriteLine("name: " + item.name + ", price: " + item.price + ", quality: " + item.quality + ", categoryId: " + item.categoryId);
            Console.WriteLine("-----------------------");

            //Search list product by categoryId
            List<Product> listProductById = new List<Product>();
            listProductById = search.findProductByCategory(Items, 4);
            Console.WriteLine("Get list product have categoryId = 4:");
            foreach (Product i in listProductById)
            {
                Console.WriteLine("name: " + i.name + ", price: " + i.price + ", quality: " + i.quality + ", categoryId: " + i.categoryId);
            }
            Console.WriteLine("-----------------------");

            //Search list product by price
            List<Product> listProductByPrice = new List<Product>();
            listProductByPrice = search.findProductByPrice(Items, 50);
            Console.WriteLine("Get list product have price <= 50:");
            foreach (Product i in listProductByPrice)
            {
                Console.WriteLine("name: " + i.name + ", price: " + i.price + ", quality: " + i.quality + ", categoryId: " + i.categoryId);
            }
            Console.WriteLine("-----------------------");

            //Sort list product by Price(use buble sort)
            List<Product> listProductSortByPrice = new List<Product>();
            listProductSortByPrice = search.sortByPrice(Items);
            Console.WriteLine("Get list product sorted by price:");
            foreach (Product i in listProductSortByPrice)
            {
                Console.WriteLine("name: " + i.name + ", price: " + i.price + ", quality: " + i.quality + ", categoryId: " + i.categoryId);
            }
            Console.WriteLine("-----------------------");

            //Sort list product by Price(use insertion sort)
            List<Product> listProductSortByName = new List<Product>();
            listProductSortByName = search.sortByName(Items);
            foreach (Product i in listProductSortByPrice)
            {
                Console.WriteLine("name: " + i.name + ", price: " + i.price + ", quality: " + i.quality + ", categoryId: " + i.categoryId);
            }
            Console.WriteLine("-----------------------");

            //Sort list product by categoryName(selection sort)
            List<Product> listProductSortCategoryName = new List<Product>();
            listProductSortCategoryName = search.sortByCategoryName(Items, Cate);
            foreach (Product i in listProductSortCategoryName)
            {
                Console.WriteLine("name: " + i.name + ", price: " + i.price + ", quality: " + i.quality + ", categoryId: " + i.categoryId);
            }
            Console.WriteLine("-----------------------");

            //Get list product have categoryName
            List<Product> ListProductCategorName = new List<Product>();
            ListProductCategorName = search.mapProductByCategory(Items, Cate);
            foreach (Product i in ListProductCategorName)
            {
                Console.WriteLine("name: " + i.name + ", price: " + i.price + ", quality: " + i.quality + ", categoryId: " + i.categoryId + ", categoryName: " + i.categoryName);
            }
            Console.WriteLine("-----------------------");

            //Get product have min price
            Product productPriceMin = new Product();
            productPriceMin = search.minByPrice(Items);
            Console.WriteLine("name: " + productPriceMin.name + ", price: " + productPriceMin.price + ", quality: " + productPriceMin.quality + ", categoryId: " + productPriceMin.categoryId);
            Console.WriteLine("-----------------------");

            //Get product have max price
            Product productPriceMax = new Product();
            productPriceMax = search.maxByPrice(Items);
            Console.WriteLine("name: " + productPriceMax.name + ", price: " + productPriceMax.price + ", quality: " + productPriceMax.quality + ", categoryId: " + productPriceMax.categoryId);
            Console.WriteLine("-----------------------");

            //Get salary
            Console.WriteLine(search.calSalaryByRecursion(100, 3));
            Console.WriteLine(search.calSalary(100, 4));
            Console.WriteLine("-----------------------");

            //Get month
            Console.WriteLine(search.calMonthByRecursion(100, 0.4));
            Console.WriteLine(search.calMonth(100, 0.4));

        }
    }

}
