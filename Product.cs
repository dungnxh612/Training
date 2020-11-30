using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int quality { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }

    class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    class Menu
    {
        public int id { get; set; }
        public string title { get; set; }
        public int parent_id { get; set; }
    }
}
