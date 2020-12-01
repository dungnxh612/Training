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
                Product key = listProduct[i];
                int j = i - 1;
                while(j >=0 && String.Compare(listProduct[j].name, key.name) < 0)
                {
                    listProduct[j + 1] = listProduct[j];
                    j--;
                }
                listProduct[j + 1] = key;

            }
            return listProduct;
        }

        public List<Product> sortByCategoryName(List<Product> listProduct, List<Category> listCategory)
        {
            foreach (Product prod in listProduct)
            {
                foreach (Category cate in listCategory)
                {
                    if (prod.categoryId == cate.id)
                    {
                        prod.categoryName = cate.name;
                    }
                }
            }


            for (int i = 0; i < listProduct.Count - 1; i++)
            {
                int min_Index = i;
                for (int j = i + 1; j < listProduct.Count; j++)
                {
                    if (String.Compare(listProduct[j].name, listProduct[min_Index].name) < 0)
                    {
                        min_Index = j;
                    }
                }
                Product tmp = listProduct[min_Index];
                listProduct[min_Index] = listProduct[i];
                listProduct[i] = tmp;
            }

            return listProduct;
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

        public double calSalaryByRecursion(double salary, int n)
        {
            if(n < 1)
            {
                return salary;
            }
            return calSalaryByRecursion(salary, n - 1) + calSalaryByRecursion(salary, n - 1)*0.1;
        }

        public double calSalary(double salary, int n)
        {
            for(int i = 0; i < n; i++)
            {
                salary = salary + salary * 0.1;
            }
            return salary;
        }
        
        public double cal(double money, double rate, int month)
        {
            if(month == 0)
            {
                return money;
            }
            return cal(money, rate, month -1) + cal(money, rate, month - 1)*rate;
        }


        public int calMonthByRecursion(double money, double rate)
        {
            int month = 1;
            while(cal(money, rate, month) < money*2)
            {
                cal(money, rate, month);
                month++;
            }
            
            return month;
        }

        public int calMonth(double money, double rate)
        {
            int month = 1;
            double tmp = money;
            while (true)
            {
                tmp = tmp + tmp * rate;
                if(tmp >= 2 * money)
                {
                    return month;
                }
                month++;

            }
        }


    }
}
