namespace LINQ4
{
    public class GetDetails : Properties
    {
        Stack<GetDetails> properties = new Stack<GetDetails>();
        public override Stack<GetDetails> Create()
        {
            GetDetails getDetails = new GetDetails();

            Console.Write("Enter Booking Id : ");
            getDetails.BookingId = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Seat Number : ");
            getDetails.SeatNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Movie Name : ");
            getDetails.MovieName = Console.ReadLine();

            Console.Write("Enter Date : ");
            getDetails.Date = DateOnly.Parse(Console.ReadLine()!);

            Console.Write("Enter Time : ");
            getDetails.Time = TimeOnly.Parse(Console.ReadLine()!);

            Console.Write("Enter Place : ");
            getDetails.Place = Console.ReadLine();

            Console.Write("Enter Language : ");
            getDetails.Language = Console.ReadLine();

            Console.Write("Enter Price : ");
            getDetails.Price = int.Parse(Console.ReadLine()!);

            properties.Push(getDetails);
            Console.WriteLine("Movie ticket confirmed");
            return properties;
        }
        public override void Read()
        {
            if (NullCheckAndCount())
            {
                foreach (var ticket in properties)
                {
                    Console.WriteLine(
                                "Movie Ticket details - " + "\n" +
                                "Booking ID             : " + ticket.BookingId + "\n" +
                                "Seat Number            : " + ticket.SeatNumber + "\n" +
                                "Movie Name             : " + ticket.MovieName + "\n" +
                                "Date                   : " + ticket.Date + "\n" +
                                "Time                   : " + ticket.Time + "\n" +
                                "Place                  : " + ticket.Place + "\n" +
                                "Language               : " + ticket.Language + "\n" +
                                "Price                  : " + ticket.Price + "\n"
                        );
                }
            }
            else
            {
                Console.WriteLine("No Movie ticket details found!, please enter details");
            }
        }
        public override void Check()
        {
            if (NullCheckAndCount())
            {
                Console.Write("Enter the Movie ticket details you want to check : ");
                string? detail = Console.ReadLine();

                if (detail == "Id")
                {
                    Console.Write("Enter the booking id to check : ");
                    int check = int.Parse(Console.ReadLine()!);

                    var Find = from item in properties
                               where item.BookingId == check
                               select item;

                    if (Find.Any())
                    {
                        Console.WriteLine("Correct booking Id");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect booking Id");
                    }
                }
                else if (detail == "Seat")
                {
                    Console.Write("Enter the seat number to check : ");
                    int check = int.Parse(Console.ReadLine()!);

                    var Find = from item in properties
                               where item.SeatNumber == check
                               select item;

                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Seat Number");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Seat Number");
                    }
                }
                else if (detail == "Movie")
                {
                    Console.Write("Enter the Movie Name to check : ");
                    string? check = Console.ReadLine();

                    var Find = from item in properties
                               where item.MovieName == check
                               select item;

                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Movie Name");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Movie Name");
                    }
                }
                else if (detail == "Date")
                {
                    Console.Write("Enter the Movie Date to check : ");
                    DateOnly check = DateOnly.Parse(Console.ReadLine()!);

                    var Find = from item in properties
                               where item.Date == check
                               select item;

                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Movie Date");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Movie Date");
                    }
                }
                else if (detail == "Time")
                {
                    Console.Write("Enter the movie Time to check : ");
                    TimeOnly check = TimeOnly.Parse(Console.ReadLine()!);

                    var Find = from item in properties
                               where item.Time == check
                               select item;

                    if (Find.Any())
                    {
                        Console.WriteLine("Correct movie Time");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect movie Time");
                    }
                }
                else if (detail == "Place")
                {
                    Console.Write("Enter the Place to check : ");
                    string? check = Console.ReadLine();

                    var Find = from item in properties
                               where item.Place == check
                               select item;

                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Place");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Place");
                    }
                }
                else if (detail == "Language")
                {
                    Console.Write("Enter the Language check : ");
                    string? check = Console.ReadLine();

                    var Find = from item in properties
                               where item.Language == check
                               select item;

                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Language");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Language");
                    }
                }
                else if (detail == "Price")
                {
                    Console.Write("Enter the Price to check : ");
                    int check = int.Parse(Console.ReadLine()!);

                    var Find = from item in properties
                               where item.Price == check
                               select item;

                    if (Find.Any())
                    {
                        Console.WriteLine("Correct Price");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Price");
                    }
                }
            }
            else
            {
                Console.WriteLine("No ticket details found!");
            }
        }
        public override bool NullCheckAndCount()
        {
            if (properties != null && properties.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
