using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var orders = new List<Order> {
                new Order {Name="Item 1", Count=02, Price =1, Type="A"},
                new Order {Name="Item 2", Count=02, Price =2 , Type="B"},
                new Order {Name="Item 3", Count=12,Price =1 , Type="A"},
                new Order {Name="Item 4", Count=02,Price =2, Type="B" },
                new Order {Name="Item 5", Count=22,Price =3 , Type="A"},
                new Order {Name="Item 6", Count=32,Price =4 , Type="B"},
                new Order {Name="Item 7", Count=21,Price =5, Type="B" },
                new Order {Name="Item 8", Count=1,Price =1 , Type="A"},
            };
            var orders2 = new List<Order> {
                new Order {Name="Item 1", Count=02, Price =1 , Type="A"},
                new Order {Name="Item 11", Count=102, Price =2 , Type="B"},
                new Order {Name="Item 12", Count=102, Price =3, Type="B" },
                new Order {Name="Item 13", Count=112,Price =4 , Type="B"},
                new Order {Name="Item 14", Count=102,Price =1, Type="B" },
                new Order {Name="Item 15", Count=122,Price =2 , Type="A"},
                new Order {Name="Item 16", Count=132,Price =3 , Type="A"},
                new Order {Name="Item 17", Count=121,Price =5, Type="A" },
                new Order {Name="Item 18", Count=11,Price =6, Type="A" },
            };
            var orderOrder = from o in orders
                                            where o.Count >= 10
                                            orderby o.Count, o.Price
                                            select o;

            foreach (var item in orderOrder)
            {
                Console.WriteLine("{0} {1} {2}", item.Name, item.Count, item.Price);
            }

            orderOrder = orderOrder.Where(x => x.Count > 10).OrderBy(x => x.Count);

            Console.WriteLine();
            foreach (var item in orderOrder)
            {
                Console.WriteLine("{0} {1} {2}", item.Name, item.Count, item.Price);
            }

            var max = (from o in orders
                         where o.Price == orders.Max(x => x.Price)
                         select o).First();

            Console.WriteLine("{0} {1} {2}", max.Name, max.Count, max.Price);

            var orderMins = from o in orders
                            where o.Price < 100000
                            select new { Name = o.Name, Price = o.Price, Per = o.Price/o.Count };
            var an = new { A = "", B=1, C=1.5};
            
            foreach (var item in orderMins)
            {               
                Console.WriteLine("{0} {1} {2}", item.Name,  item.Price,item.Per);
            }
            m1(an);

            m1(an);

            Order[] arrOrder = orderOrder.ToArray();

            var allOrders = orders.Union(orders2);

            var allOrders1 = (new int[] { 1,2,3,4,5,6}).Intersect((new int[] {  4, 5, 6,0,10,7,8,9,0 }));

            var allOrders2 = (new int[] { 1, 2, 3, 4, 5, 6 }).Except((new int[] { 4, 5, 6, 0, 10, 7, 8, 9, 0 }));
            Console.WriteLine("All orders");
            foreach (var item in allOrders)
            {
                Console.WriteLine("{0} {1} {2}", item.Name, item.Count, item.Price);
            }

            foreach (var item in allOrders2)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            var grop = from o in allOrders
                       group o by o.Type into t
                       select new { Category = t.Key, Price = allOrders.Where(x=>x.Type==t.Key).Sum(x=>x.Price),
                       Avg = allOrders.Where(x => x.Type == t.Key).Average(x => x.Price),
                       };

            Console.WriteLine();
            foreach (var item in grop)
            {
                Console.WriteLine("{0} {1} {2}", item.Category,item.Price, item.Avg);
            }


        }

        public static void m1(object o) {            
            Console.WriteLine(o);
        }
    }


    class Order
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public string Type { get; set; }
    }
}
