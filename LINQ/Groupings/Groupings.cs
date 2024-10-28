using LINQForBeginners.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQForBeginners.LINQ.Groupings
{
    public class Groupings
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int GroupingSyntax()
        {
            #region groupby-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numberGroups = from n in numbers group n by n % 5 into g
                               select (Remainder: g.Key, Numbers: g);

            foreach (var g in numberGroups)
            {
                Console.WriteLine($"Numbers with a remainder of {g.Remainder} when divided by 5:");
                foreach (var n in g.Numbers)
                {
                    Console.WriteLine(n);
                }
            }
            #endregion
            return 0;
        }

        public int GroupByProperty()
        {
            #region groupby-property
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var wordGroups = from w in words
                             group w by w[0] into g
                             select (FirstLetter: g.Key, Words: g);

            foreach (var g in wordGroups)
            {
                Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
                foreach (var w in g.Words)
                {
                    Console.WriteLine(w);
                }
            }
            #endregion
            return 0;
        }


        public void GroupByCategory()
        {
            List<Product> products = GetProductList();

            var orderGroups = from p in products
                              group p by p.Category into g
                              select (Category: g.Key, Products: g);


            foreach (var orderGroup in orderGroups)
            {
                Console.WriteLine($"Products in {orderGroup.Category} category:");
                foreach (var product in orderGroup.Products)
                {
                    Console.WriteLine($"\t{product}");
                }
            }

        }

        public void NestedGrouBy()
        {
            List<Customer> customers = GetCustomerList();

            var customerOrderGroups = from c in customers
                                      select
                                      (
                                      c.CompanyName,
                                      YearGroups: from o in c.Orders
                                                  group o by o.OrderDate.Year into yg
                                                  select (Year: yg.Key, MonthGroups: from o in yg
                                                                                     group o by o.OrderDate.Month into mg
                                                                                     select (Month: mg.Key, Orders: mg))
                                      );

            foreach (var ordersByCustomer in customerOrderGroups)
            {
                Console.WriteLine($"Customer Name: {ordersByCustomer.CompanyName}");
                foreach (var ordersByYear in ordersByCustomer.YearGroups)
                {
                    Console.WriteLine($"\tYear: {ordersByYear.Year}");
                    foreach (var ordersByMonth in ordersByYear.MonthGroups)
                    {
                        Console.WriteLine($"\t\tMonth: {ordersByMonth.Month}");
                        foreach (var order in ordersByMonth.Orders)
                        {
                            Console.WriteLine($"\t\t\tOrder: {order}");
                        }
                    }
                }
            }

        }

        


    }
}
