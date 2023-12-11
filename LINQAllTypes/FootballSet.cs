namespace LINQAllTypes
{
    public class FootballSet
    {
        public void MergeSet()
        {
            List<Football> footballSet1 = Football.footballSet1;
            List<Football> footballSet2 = Football.footballSet2;

            Console.WriteLine("Set Operations ---------------------- ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Using Except : ");
            Console.WriteLine();

            var except = footballSet1.Except(footballSet2, new PlayerComparer());

            foreach(var item in except)
            {
                Console.WriteLine("Country Id : " + item.CountryId + " ---> " + item.PlayerName);
            }
            Console.WriteLine();
            Console.WriteLine("Using Intersect : ");
            Console.WriteLine();

            var intersect = footballSet1.Intersect(footballSet2, new PlayerComparer());

            foreach(var item in intersect)
            {
                Console.WriteLine("Country Id : " + item.CountryId + " ---> " + item.PlayerName);
            }
            Console.WriteLine();
            Console.WriteLine("Using Union : ");
            Console.WriteLine();

            var union = footballSet1.Union(footballSet2, new PlayerComparer());

            foreach(var item in union)
            {
                Console.WriteLine("Country Id : " + item.CountryId + " ---> " + item.PlayerName);
            }
            Console.WriteLine();
            Console.WriteLine("Using Distinct : ");
            Console.WriteLine();

            var distinct = footballSet1.Distinct(new PlayerComparer());

            foreach(var item in distinct)
            {
                Console.WriteLine(item.PlayerName);
            }
        }
    }
    public class PlayerComparer : IEqualityComparer<Football>
    {
        public bool Equals(Football player1, Football player2)
        {
            if(player1.CountryId == player2.CountryId)
            {
                return true;
            }
            return false;
        }
        public int GetHashCode(Football obj)
        {
            return obj.CountryId.GetHashCode();
        }
    }
}
