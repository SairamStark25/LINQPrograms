namespace LINQAllTypes
{
    public class OrderMethod 
    {
        public void GetOrders()
        {
            List<OrderProperties> orders1 = OrderProperties.orders1;
            List<OrderProperties> orders2 = OrderProperties.orders2;

            Console.WriteLine("Filtering operations -------------------");
            Console.WriteLine();

            var Filter = from item in orders1
                         where item.Price < 500
                         select item;

            foreach(var item in Filter)
            {
                Console.WriteLine(item.OrderName + " ---> " + item.Price);
            }
            Console.WriteLine();

            Console.WriteLine("Projection operations ------------------");
            Console.WriteLine();
            Console.WriteLine("Using select : ");

            var Find = from item in orders1
                       select item.Price;
            //select item;

            foreach(var item in Find)
            {
                Console.WriteLine(item);
                //Console.WriteLine(
                //                  " Id : " + item.Id +
                //                  " OrderName : " + item.OrderName +
                //                  " Quantity : " + item.Quantity +
                //                  " Price : " + item.Price
                //              );
            }

            Console.WriteLine();
            Console.WriteLine("Using select many : ");
            Console.WriteLine();

            var selectedMany = orders2.SelectMany(order => order.Items!);

            foreach (var order in orders2)
            {
                Console.WriteLine("Order : " + order.OrderName + " : " + "Price : " + order.Price);

                foreach (var item in order.Items!)
                {
                    Console.WriteLine(" ---> Item : " + item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Using select many for particular ID : ");
            Console.WriteLine();

            var selectItem = orders2.Where(order => order.Id == 1 && order.OrderName == "Pizza")
                                    .SelectMany(order => order.Items!);

            foreach (var item in selectItem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Sorting operations ---------------------");
            Console.WriteLine();

            Console.WriteLine("Ascending Order : ");
            Console.WriteLine();
            var FindAsc = from item in orders1
                          orderby item.Price
                          select item;

            foreach (var item in FindAsc)
            {
                Console.WriteLine(item.Price);
            }

            Console.WriteLine();
            Console.WriteLine("Descending Order : ");
            Console.WriteLine();

            var FindDesc = from item in orders1
                           orderby item.Price descending
                           select item;

            foreach (var item in FindDesc)
            {
                Console.WriteLine(item.Price);
            }

            Console.WriteLine();
            Console.WriteLine("Mutiple sorting : ");
            Console.WriteLine();
            var MultiSort = from item in orders1
                            orderby item.OrderName, item.Price, item.Id
                            select item;

            foreach (var item in MultiSort)
            {
                Console.WriteLine("ID: " + item.Id + " ---> " +
                                  "Order name : " + item.OrderName + " ---> " +
                                  "Price : " +item.Price);
            }
            Console.WriteLine();
            Console.WriteLine("Reverse : ");

            orders1.Reverse();

            foreach(var item in orders1)
            {
                Console.WriteLine("ID: " + item.Id + " ---> " +
                                  "Order name : " + item.OrderName + " ---> " +
                                  "Price : " + item.Price);
            }

            Console.WriteLine();

            Console.WriteLine("Using ThenBy and ThenByDescending Operation :");

            var OrderByOperation = orders1.OrderBy(item => item.OrderName); 

            foreach(var item in OrderByOperation)
            {
                Console.WriteLine("Order Name : " + item.OrderName + " ---> " + " Order Price : " + item.Price);
            }

            Console.WriteLine();
            Console.WriteLine("Using ThenBy Opeartion :");

            var ThenByOperation = OrderByOperation.ThenBy(item => item.Price);

            //var ThenByOperation = from item in OrderByOperation
            //                      orderby item.Price
            //                      select item;

            foreach (var item in ThenByOperation)// using ThenBy
            {
                Console.WriteLine("Order Price : " + item.Price + " ---> " + " Order Name : " + item.OrderName);
            }

            Console.WriteLine();
            Console.WriteLine("Using ThenByDescending Opeartion :");

            var ThenByDesc = OrderByOperation.ThenByDescending(item => item.Price);

            //var ThenByDesc = from item in ThenByOperation
            //                 orderby item.Price descending
            //                 select item;

            foreach (var item in ThenByDesc)// using ThenByDescending
            {
                Console.WriteLine("Order Price : " + item.Price + " ---> " + " Order Name : " + item.OrderName);
            }

            Console.WriteLine();
            Console.WriteLine("Grouping operations -------------------");
            Console.WriteLine();
            Console.WriteLine("Using GroupBy Opeartion :");

            var Group = from item in orders1
                        group item by item.Quantity into newGroup // 2 2 5 1 1 1
                        orderby newGroup.Key // it will sort the quantity // 1 2 5
                        select newGroup;

            foreach (var quantity in Group)
            {
                Console.WriteLine("Quantity : " + quantity.Key);

                foreach (var orderName in quantity)
                {
                    Console.WriteLine("----> " + orderName.Quantity + " " + orderName.OrderName);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Using ToLookup Opeartion :");

            var toLookUp = orders1.ToLookup(item => item.Quantity);

            foreach (var item in Group)
            {
                Console.WriteLine("Quantity : " + item.Key);

                foreach (var order in item)
                {
                    Console.WriteLine("----> " + order.Quantity + " " + order.OrderName);
                }
            }
        }
    }
}
