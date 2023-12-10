namespace LINQAllTypes
{
    public class Football
    {
        public int JerseyNumber { get; set; }
        public string? PlayerName { get; set; }
        public int CountryId { get; set; }
        public int PlayerGoals { get; set; }

        public static List<Football> football = new List<Football>() // for join
        {
            new Football { JerseyNumber = 10, PlayerName = "Messi", CountryId = 1, PlayerGoals = 861 },
            new Football { JerseyNumber = 7, PlayerName = "Ronaldo", CountryId = 2, PlayerGoals = 892 },
            new Football { JerseyNumber = 11, PlayerName = "Casemiro", CountryId = 3, PlayerGoals = 320 },
            new Football { JerseyNumber = 7, PlayerName = "Di maria", CountryId = 1, PlayerGoals = 754 },
            new Football { JerseyNumber = 8, PlayerName = "Lewandowski", CountryId = 8, PlayerGoals = 653 },
            new Football { JerseyNumber = 14, PlayerName = "Rafa Silva", CountryId = 2, PlayerGoals = 622 },
            new Football { JerseyNumber = 10, PlayerName = "Neymar", CountryId = 3, PlayerGoals = 811 },
            new Football { JerseyNumber = 11, PlayerName = "Kane", CountryId = 5, PlayerGoals = 568 },
            new Football { JerseyNumber = 12, PlayerName = "Pogba", CountryId = 6, PlayerGoals = 538 },
            new Football { JerseyNumber = 14, PlayerName = "Rooney", CountryId = 8, PlayerGoals = 627 },
        };

        public static List<Football> footballSet1 = new List<Football>() // for set
        {
            new Football { JerseyNumber = 10, PlayerName = "Messi", CountryId = 1, PlayerGoals = 861 },
            new Football { JerseyNumber = 10, PlayerName = "Messi", CountryId = 1, PlayerGoals = 861 },
            new Football { JerseyNumber = 10, PlayerName = "Messi", CountryId = 1, PlayerGoals = 861 },
            new Football { JerseyNumber = 7, PlayerName = "Ronaldo", CountryId = 2, PlayerGoals = 892 },
            new Football { JerseyNumber = 11, PlayerName = "Casemiro", CountryId = 3, PlayerGoals = 320 },
            new Football { JerseyNumber = 7, PlayerName = "Di maria", CountryId = 4, PlayerGoals = 754 },
            new Football { JerseyNumber = 7, PlayerName = "kane", CountryId = 5, PlayerGoals = 545 },
        };

        public static List<Football> footballSet2 = new List<Football>() // for set
        {
            new Football { JerseyNumber = 7, PlayerName = "Ronaldo", CountryId = 2, PlayerGoals = 653 },
            new Football { JerseyNumber = 14, PlayerName = "Rafa Silva", CountryId = 7, PlayerGoals = 622 },
            new Football { JerseyNumber = 10, PlayerName = "Messi", CountryId = 1, PlayerGoals = 811 },
            new Football { JerseyNumber = 11, PlayerName = "Casemiro", CountryId = 3, PlayerGoals = 568 },
            new Football { JerseyNumber = 15, PlayerName = "Pogba", CountryId = 8, PlayerGoals = 568 },
            new Football { JerseyNumber = 8, PlayerName = "Umtiti", CountryId = 9, PlayerGoals = 568 },
        };

        public static List<Football> football3joins = new List<Football>() // for connecting 3 lists
        {
            new Football { JerseyNumber = 10, PlayerName = "Messi", CountryId = 1 },
            new Football { JerseyNumber = 7, PlayerName = "Ronaldo", CountryId = 2 },
            new Football { JerseyNumber = 11, PlayerName = "Casemiro", CountryId = 3 },
            new Football { JerseyNumber = 7, PlayerName = "Di maria", CountryId = 1 },
            new Football { JerseyNumber = 8, PlayerName = "Lewandowski", CountryId = 11 },
            new Football { JerseyNumber = 14, PlayerName = "Rafa Silva", CountryId = 2 },
            new Football { JerseyNumber = 10, PlayerName = "Neymar", CountryId = 3 },
            new Football { JerseyNumber = 11, PlayerName = "Kane", CountryId = 5 },
            new Football { JerseyNumber = 12, PlayerName = "Pogba", CountryId = 6 },
            new Football { JerseyNumber = 14, PlayerName = "Rooney", CountryId = 12 },
        };
    }
    public class Team
    {
        public int CountryId { get; set; }
        public string? CountryName { get; set; }

        public static List<Team> team = new List<Team>() // for join, set and 3 lists
        {
            new Team { CountryId = 1, CountryName = "Argentina" },
            new Team { CountryId = 2, CountryName = "Portugal" },
            new Team { CountryId = 3, CountryName = "Brazil" },
            new Team { CountryId = 5, CountryName = "England" },
            new Team { CountryId = 6, CountryName = "France" },
            new Team { CountryId = 9, CountryName = "Croatia" },
            new Team { CountryId = 10, CountryName = "Germany" },
        };
    }
    public class TransferClub
    {
        public int CountryId { get; set; }
        public string? NewClub { get; set; }

        public static List<TransferClub> transferTeam = new List<TransferClub>() // for connecting 3 lists
        {
            new TransferClub{ CountryId = 1, NewClub = "InterMiami" },
            new TransferClub{ CountryId = 2, NewClub = "Al Nassr" },
            new TransferClub{ CountryId = 3, NewClub = "Man United" },
            new TransferClub{ CountryId = 4, NewClub = "InterMiami" },
            new TransferClub{ CountryId = 5, NewClub = "Spurs" },
            new TransferClub{ CountryId = 6, NewClub = "Man city" },
            new TransferClub{ CountryId = 7, NewClub = "Arsenal" },
            new TransferClub{ CountryId = 8, NewClub = "PSG" },
            new TransferClub{ CountryId = 9, NewClub = "Real Madrid" },
            new TransferClub{ CountryId = 10, NewClub = "Sevilla FC" }
        };
    }
}
