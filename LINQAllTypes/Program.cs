namespace LINQAllTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("!!! LINQ Operations !!!" + "\n" + "\n" +
                              "0 ---> Exit" + "\n" + "\n" +
                              "1 ---> Filtering, Projection, Sorting, Grouping" + "\n" + "\n" + // OrderMethod
                              "2 ---> Join, Aggregation, Partitioning" + "\n" + "\n" + // UsingJoins
                              "3 ---> Set Operations" + "\n" + "\n" + // FootballSet
                              "4 ---> Connecting 3 tables" + "\n" + "\n" // ThreeTables
                    );

                int option = int.Parse(Console.ReadLine()!);

                if(option == 0)
                {
                    Console.WriteLine("Terminated!");
                    break;
                }
                else if(option == 1)
                {
                    OrderMethod order = new OrderMethod();
                    order.GetOrders();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(option == 2)
                {
                    UsingJoins obj = new UsingJoins();
                    obj.GetMatch();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(option == 3)
                {
                    FootballSet obj = new FootballSet();
                    obj.MergeSet();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(option == 4)
                {
                    ThreeTables obj = new ThreeTables();
                    obj.JoinThree();
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}