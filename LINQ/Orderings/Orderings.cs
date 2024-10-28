using LINQForBeginners.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQForBeginners.LINQ.Orderings
{
    public class Orderings
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int OrderByProducts()
        {
            #region orderby-user-types
            List<Product> products = GetProductList();

            var sortedProducts = from prod in products
                                 orderby prod.ProductName
                                 select prod;

            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product);
            }
            #endregion
            return 0;
        }

        public int OrderByProductsDescending()
        {
            #region orderby-user-types
            List<Product> products = GetProductList();

            var sortedProducts = from prod in products
                                 orderby prod.ProductName descending
                                 select prod;

            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product);
            }
            #endregion
            return 0;
        }


        public int OrderByWithCustomComparer()
        {
            #region orderby-custom-comparer
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
            #endregion
            return 0;
        }


        public int DescendingCustomComparer()
        {
            #region desc-custom-comparer
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
            #endregion
            return 0;
        }
    }
    // Custom comparer for use with ordering operators
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y) =>
            string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}
