namespace LINQ3
{
    public class SelectOption : GetCoffee
    {
        public void Display()
        {
            while (true)
            {
                Console.WriteLine("Select Option : " + "\n" +
                                                  "0 - Exit" + "\n" +
                                                  "1 - Create" + "\n" +
                                                  "2 - Read" + "\n" +
                                                  "3 - Check"
                                  );
                int select = int.Parse(Console.ReadLine()!);

                if (select == 0)
                {
                    Console.WriteLine("Terminated!");
                    break;
                }
                else if (select == 1)
                {
                    Create();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (select == 2)
                {
                    Read();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (select == 3)
                {
                    Check();
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid input, enter proper option!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
