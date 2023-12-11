using System.Linq;

namespace LINQAllTypes
{
    public class UsingJoins
    {
        public void GetMatch()
        {
            List<Football> football = Football.football;
            List<Team> team = Team.team;

            Console.WriteLine("Join operations -------------------");
            Console.WriteLine();
            Console.WriteLine("Inner join : ");
            var innerJoin = from footballList in football
                            join teamList in team on footballList.CountryId equals teamList.CountryId
                            select new
                            {
                                Jersey = footballList.JerseyNumber,
                                Player = footballList.PlayerName,
                                Country = teamList.CountryName,
                                Goals = footballList.PlayerGoals
                            };
            foreach (var item in innerJoin)
            {
                Console.WriteLine(
                                  "Jersey Number : " + item.Jersey + " ---> " +
                                  "Player Name : " + item.Player + " ---> " +
                                  "Player Country : " + item.Country + " ---> " +
                                  "Players Goals : " + item.Goals
                                 );
            }
            Console.WriteLine();
            Console.WriteLine("Left join : ");
            Console.WriteLine();
            var leftJoin = from footballList in football
                           join teamList in team on footballList.CountryId equals teamList.CountryId into joined
                           from x in joined.DefaultIfEmpty()
                           select new
                           {                                   
                               ID = x != null ? x.CountryId : 0, // condition ? true : false  
                               Player = footballList.PlayerName,
                               Country = x != null ? x.CountryName : "NULL",
                           };

            foreach (var item in leftJoin)
            {
                Console.WriteLine(
                                "Country ID : " + item.ID + " ---> " +
                                "Player Name : " + item.Player + " ---> " +
                                "Player Country : " + item.Country + " ---> "
                                );
            }
            Console.WriteLine();
            Console.WriteLine("Right join : ");
            Console.WriteLine();
            var rightJoin = from teamList in team
                            join footballList in football on teamList.CountryId equals footballList.CountryId into joined
                            from x in joined.DefaultIfEmpty()
                            select new
                            {
                                ID = x != null ? x.CountryId : 0,
                                Player = x != null ? x.PlayerName : "NULL",
                                Country = teamList.CountryName
                            };

            foreach (var item in rightJoin)
            {
                Console.WriteLine(
                                "Country ID : " + item.ID + " ---> " +
                                "Player Name : " + item.Player + " ---> " +
                                "Player Country : " + item.Country
                                );
            }
            Console.WriteLine();
            Console.WriteLine("Full join : ");
            Console.WriteLine();
            var fullOuterJoin = (from footballList in football
                                 join teamList in team on footballList.CountryId equals teamList.CountryId into joined
                                 from x in joined.DefaultIfEmpty()
                                 select new
                                 {
                                     Player = footballList.PlayerName,
                                     ID = x != null ? x.CountryId : 0,
                                     Country = x!=null ? x.CountryName : "NULL"
                                 }).Union
                     (from teamList in team
                      join footballList in football on teamList.CountryId equals footballList.CountryId into joined
                      from y in joined.DefaultIfEmpty()
                      where y == null
                      select new
                      {
                          Player = y != null ? y.PlayerName : "NULL",
                          ID = y != null ? y.CountryId : 0,
                          Country = teamList.CountryName
                      });

            foreach (var item in fullOuterJoin)
            {
                Console.WriteLine(
                          "Country ID : " + item.ID + " ---> " +
                          "Player Name : " + item.Player + " ---> " +
                          "Player Country : " + item.Country + " ---> "
                 );
            }

            Console.WriteLine();
            Console.WriteLine("Cross join : ");
            Console.WriteLine();

            var CrossJoin = from footballList in football
                            from teamList in team
                            select new
                            {
                                Jersey = footballList.JerseyNumber,
                                Player = footballList.PlayerName,
                                Country = teamList.CountryName,
                                Goals = footballList.PlayerGoals
                            };

            foreach (var item in CrossJoin)
            {
                Console.WriteLine(
                                  "Jersey Number : " + item.Jersey + " ---> " +
                                  "Player Name : " + item.Player + " ---> " +
                                  "Player Country : " + item.Country + " ---> " +
                                  "Players Goals : " + item.Goals
                                 );
            }

            Console.WriteLine();
            Console.WriteLine("Aggregation operations -------------------");
            Console.WriteLine();
            Console.Write("Sum --- > ");

            var totalGoals = football.Sum(goal => goal.PlayerGoals); // Sum
            Console.WriteLine("Player total goals : " + totalGoals);

            Console.Write("Max ---> ");

            var MaxGoal = football.Max(maxGoal => maxGoal.PlayerGoals); // Max
            Console.WriteLine("Player with maximum goal : " + MaxGoal);

            Console.Write("Min ---> ");

            var MinGoal = football.Min(minGoal => minGoal.PlayerGoals); // Min
            Console.WriteLine("Player with minimum goal : " + MinGoal);

            Console.Write("Count ---> ");

            var PlayersCount = football.Count; // Count
            Console.WriteLine("Total Players : " + PlayersCount);

            Console.Write("Average ---> ");

            var average = football.Average(avg => avg.JerseyNumber); // Average
            Console.WriteLine("Average JerseyNumber : " + average);

            Console.WriteLine();
            Console.WriteLine("Partitioning operations -------------------");
            Console.WriteLine();

            Console.WriteLine("Using Skip : ");

            var skipping = football.Skip(3); // skip

            foreach (var item in skipping)
            {
                Console.WriteLine(item.PlayerName);
            }
            Console.WriteLine();
            Console.WriteLine("Using SkipWhile : ");

            var skipWhile = football.SkipWhile(when => when.PlayerGoals == 861); // SkipWhile

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.PlayerName);
            }
            Console.WriteLine();
            Console.WriteLine("Using Take : ");

            var taking = football.Take(6); // Take

            foreach (var item in taking)
            {
                Console.WriteLine(item.PlayerName);
            }
            Console.WriteLine();
            Console.WriteLine("Using TakeWhile : ");

            var takeWhile = football.TakeWhile(when => when.CountryId == 1); // TakeWhile

            foreach (var item in takeWhile)
            {
                Console.WriteLine(item.PlayerName);
            }
            Console.WriteLine();
            Console.WriteLine("Using TakeLast : ");

            var takeLast = football.TakeLast(3); // TakeWhile

            foreach (var item in takeLast)
            {
                Console.WriteLine(item.PlayerName);
            }
        }
    }
}
