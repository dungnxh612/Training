using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class Search
    {
        public Product findProduct(List<Product> listProduct, String nameProduct)
        {
            foreach (Product item in listProduct)
            {
                if (item.name == nameProduct)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Product> findProductByCategory(List<Product> listProduct, int categoryId)
        {
            List<Product> Items = new List<Product>();

            foreach (Product item in listProduct)
            {
                if (item.categoryId == categoryId)
                {
                    Items.Add(item);
                }
            }
            return Items;
        }

        public List<Product> findProductByPrice(List<Product> listProduct, int price)
        {
            List<Product> Items = new List<Product>();

            foreach (Product item in listProduct)
            {
                if (item.price <= price)
                {
                    Items.Add(item);
                }
            }
            return Items;
        }

        public List<Product> sortByPrice(List<Product> listProduct)
        {
            Product tmp = new Product();
            for(int i = 0; i < listProduct.Count - 1; i++)
            {
                for(int j = 0; j < listProduct.Count - 1; j++)
                {
                    if(listProduct[j].price > listProduct[j+1].price)
                    {
                        tmp = listProduct[j];
                        listProduct[j] = listProduct[j+1];
                        listProduct[j+1] = tmp;
                    }
                }
            }
            return listProduct;
        }

        public List<Product> sortByName(List<Product> listProduct)
        {
            for(int i=1; i< listProduct.Count; i++)
            {
                string key = listProduct[i].name;
                int j = i - 1;
                while(j >=0 && String.Compare(listProduct[j].name, key) < 0)
                {
                    listProduct[j + 1].name = listProduct[j].name;
                    j--;
                }
                listProduct[j + 1].name = key;

            }
            return listProduct;
        }

        public List<Product> sortByCategoryName(List<Product> listProduct, List<Category> listCategory)
        {
            List<Product> listP = new List<Product>();

            for(int i = 0; i < listCategory.Count - 1; i++)
            {
                int min_Index = i;
                for(int j = i + 1; j < listCategory.Count; j++)
                {
                    if(String.Compare(listCategory[j].name, listCategory[min_Index].name) < 0)
                    {
                        min_Index = j;
                    }
                }
                string tmp = listCategory[min_Index].name;
                listCategory[min_Index].name = listCategory[i].name;
                listCategory[i].name = tmp;
            }

            foreach(Category item in listCategory)
            {
                foreach(Product i in listProduct)
                {
                    if(item.id == i.categoryId)
                    {
                        listP.Add(i);
                    }
                }
            }
            return listP;
        }

        public List<Product> mapProductByCategory(List<Product> listProduct, List<Category> listCategory)
        {
            foreach(Product item in listProduct)
            {
                foreach(Category i in listCategory)
                {
                    if(item.categoryId == i.id)
                    {
                        item.categoryName = i.name;
                        break;
                    }
                }
            }

            return listProduct;
        }

        public Product minByPrice(List<Product> listProduct)
        {
            Product product = listProduct[0];
            foreach(Product item in listProduct)
            {
                if(item.price < product.price)
                {
                    product = item;
                }
            }
            
            return product;
        }

        public Product maxByPrice(List<Product> listProduct)
        {
            Product product = listProduct[0];
            foreach (Product item in listProduct)
            {
                if (item.price > product.price)
                {
                    product = item;
                }
            }

            return product;
        }
    }
}
