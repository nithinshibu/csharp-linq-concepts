using LINQForBeginners.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQForBeginners.LINQ.Partitions
{
    public class Partitions
    {
        public List<Product> GetProductList() => Products.ProductList;

        public List<Customer> GetCustomerList() => Customers.CustomerList;


        public int TakeSyntax()
        {
            #region take-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var first3Numbers = numbers.Take(3);

            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

        public void NestedTake()
        {
            List<Customer> customers = GetCustomerList();

            var first3WAOrders = (from c in customers from order in c.Orders where c.Region=="WA" select(c.CustomerID,order.OrderID,order.OrderDate)).Take(3);

            Console.WriteLine("First 3 orders in WA:");
            foreach (var order in first3WAOrders)
            {
                Console.WriteLine(order);
            }

        }

        public int SkipSyntax()

        {
            #region skip-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var allButFirst4Numbers = numbers.Skip(4);

            Console.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

        public int NestedSkip()
        {
            #region nested-skip
            List<Customer> customers = GetCustomerList();

            var waOrders = from cust in customers
                           from order in cust.Orders
                           where cust.Region == "WA"
                           select (cust.CustomerID, order.OrderID, order.OrderDate);

            var allButFirst2Orders = waOrders.Skip(2);

            Console.WriteLine("All but first 2 orders in WA:");
            foreach (var order in allButFirst2Orders)
            {
                Console.WriteLine(order);
            }
            #endregion
            return 1;
        }

        //TakeWhile only considers elements from the start of the sequence until it finds the first element that fails the condition. After that, it stops, even if subsequent elements would satisfy the condition.

        public int TakeWhileSyntax()
        {
            #region takewhile-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            Console.WriteLine("First numbers less than 6:");
            foreach (var num in firstNumbersLessThan6)
            {
                Console.WriteLine(num);
            }
            #endregion
            return 0;
        }

        //SkipWhile skips elements at the beginning of the sequence until it finds an element that does not meet the condition. After that, it includes all remaining elements, regardless of whether they satisfy the condition or not.

        public int SkipWhileSyntax()
        {
            #region skipwhile-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // In the lambda expression, 'n' is the input parameter that identifies each
            // element in the collection in succession. It is is inferred to be
            // of type int because numbers is an int array.
            var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

            Console.WriteLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

        /* OUTPUT:
         * 
         * All elements starting from first element divisible by 3:
            3
            9
            8
            6
            7
            2
            0
         * 
         */



    }
}
