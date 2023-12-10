namespace LINQ3
{
    public class GetCoffee : IProperties
    {
        public int CoffeeId { get; set; }
        public string? CustomerName { get; set; }
        public string? CoffeeName { get; set; }
        public int Quantity { get; set; }
        public bool Sugar { get; set; }
        public decimal Price { get; set; }

        Queue<IProperties> properties = new Queue<IProperties>();
        
        public Queue<IProperties> Create()
        {
            GetCoffee getCoffee = new GetCoffee();

            Console.Write("Enter Coffee ID : ");
            getCoffee.CoffeeId = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Customer Name : ");
            getCoffee.CustomerName = Console.ReadLine();

            Console.Write("Enter Coffee Name : ");
            getCoffee.CoffeeName = Console.ReadLine();

            Console.Write("Enter Quantity : ");
            getCoffee.Quantity = int.Parse(Console.ReadLine()!);

            Console.Write("With sugar give true, without sugar give false : ");
            getCoffee.Sugar = bool.Parse(Console.ReadLine()!);

            Console.Write("Enter Price : ");
            getCoffee.Price = decimal.Parse(Console.ReadLine()!);

            properties.Enqueue(getCoffee);
            Console.WriteLine("Coffee details Created!");
            return properties;
        }
        public void Read()
        {
            if (NullCheckAndCount())
            {
                foreach (var coffee in properties)
                {
                    Console.WriteLine(
                                "Coffee details - " + "\n" +
                                "Coffee Id          : " + coffee.CoffeeId + "\n" +
                                "Customer Name      : " + coffee.CustomerName + "\n" +
                                "Coffee Name        : " + coffee.CoffeeName + "\n" +
                                "Quantity           : " + coffee.Quantity + "\n" +
                                "Sugar              : " + coffee.Sugar + "\n" +
                                "Price              : " + coffee.Price + "\n"
                        );
                }
            }
            else
            {
                Console.WriteLine("No coffee details found!");
            }
        }
        public void Check()
        {
            if (NullCheckAndCount())
            {
                Console.Write("Enter the Coffee details you want to check : ");
                string? detail = Console.ReadLine();

                if (detail == "Id")
                {
                    Console.Write("Enter the Customer id to check : ");
                    int check = int.Parse(Console.ReadLine()!);

                    var Find = from item in properties
                               where item.CoffeeId == check
                               select item;
                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Customer Id");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Customer Id");
                    }
                }
                else if (detail == "Name")
                {
                    Console.Write("Enter the Customer name to check : ");
                    string? check = Console.ReadLine();

                    var Find = from item in properties
                               where item.CustomerName == check
                               select item;
                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Customer name");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Customer name");
                    }
                }
                else if (detail == "Coffee")
                {
                    Console.Write("Enter the Coffee name to check : ");
                    string? check = Console.ReadLine();

                    var Find = from item in properties
                               where item.CoffeeName == check
                               select item;
                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Coffee name");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Coffee name");
                    }
                }
                else if (detail == "Quantity")
                {
                    Console.Write("Enter the Coffee Quantity to check : ");
                    int check = int.Parse(Console.ReadLine()!);

                    var Find = from item in properties
                               where item.Quantity == check
                               select item;
                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Coffee Quantity");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Coffee Quantity");
                    }
                }
                else if (detail == "Sugar")
                {
                    Console.Write("Enter the Sugar level to check : ");
                    bool check = bool.Parse(Console.ReadLine()!);

                    var Find = from item in properties
                               where item.Sugar == check
                               select item;
                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Sugar level");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Sugar level");
                    }
                }
                else if (detail == "Price")
                {
                    Console.Write("Enter the Coffee name to check : ");
                    decimal check = decimal.Parse(Console.ReadLine()!);

                    var Find = from item in properties
                               where item.Price == check
                               select item;
                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Coffee Price");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Coffee Price");
                    }
                }
            }
            else
            {
                Console.WriteLine("No coffee details found!");
            }
        }
        public bool NullCheckAndCount()
        {
            if (properties != null && properties.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
