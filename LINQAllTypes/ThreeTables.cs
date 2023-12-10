using System.Diagnostics;

namespace LINQAllTypes
{
    public class ThreeTables
    {
        public void JoinThree()
        {
            List<Football> football3Join = Football.football3joins;
            List<Team> team = Team.team;
            List<TransferClub> transferTeam = TransferClub.transferTeam;

            Console.WriteLine("Join operations using 3 tables -------------------");
            Console.WriteLine();
            Console.WriteLine("Inner join : ");

            var innerJoin = from footballList in football3Join
                            join teamList in team on footballList.CountryId equals teamList.CountryId
                            join transfer in transferTeam on teamList.CountryId equals transfer.CountryId
                            select new
                            {
                                ID = transfer.CountryId,
                                Jersey = footballList.JerseyNumber,
                                Player = footballList.PlayerName,
                                Country = teamList.CountryName,
                                Transfer = transfer.NewClub,
                            };

            foreach (var item in innerJoin)
            {
                Console.WriteLine(
                                  "Country ID : " + item.ID + " -- " +
                                  "Jersey Number : " + item.Jersey + " -- " +
                                  "Player Name : " + item.Player + " -- " +
                                  "Player Country : " + item.Country + " -- " +
                                  "New Team : " + item.Transfer 
                                 );
            }
            Console.WriteLine();
            Console.WriteLine("Left join : "); 
            Console.WriteLine();

            var leftJoin = from footballList in football3Join
                           join teamList in team on footballList.CountryId equals teamList.CountryId into joined
                           from joinedTeam in joined.DefaultIfEmpty()
                           join transfer in transferTeam on footballList.CountryId equals transfer.CountryId into newClub
                           from joinedTransfer in newClub.DefaultIfEmpty()
                           select new
                           {
                               Player = footballList.PlayerName,            
                               Country = joinedTeam != null ? joinedTeam.CountryName : "NULL",
                               TransferClub = joinedTransfer != null ? joinedTransfer.NewClub : "NULL"
                           };
            
            foreach (var item in leftJoin)
            {
                Console.WriteLine(
                                "Player Name : " + item.Player + " -- " +
                                "Player Country : " + item.Country + " -- " +
                                "New Team : " + item.TransferClub
                                );
            }

            Console.WriteLine();
            Console.WriteLine("Right join : ");
            Console.WriteLine();

            var rightJoin = from teamList in team
                            join footballList in football3Join on teamList.CountryId equals footballList.CountryId into joined
                            from joinedTeam in joined.DefaultIfEmpty()
                            join transfer in transferTeam on teamList.CountryId equals transfer.CountryId into newClub
                            from joinedTransfer in newClub.DefaultIfEmpty()
                            select new
                            {
                                Player = joinedTeam != null ? joinedTeam.PlayerName : "NULL",
                                Country = teamList.CountryName,
                                TransferClub = joinedTransfer.NewClub,
                            };
            foreach (var item in rightJoin)
            {
                Console.WriteLine(
                                "Player Name : " + item.Player + " -- " +
                                "Player Country : " + item.Country + " -- " +
                                "New Team : " + item.TransferClub
                                );
            }

            Console.WriteLine();
            Console.WriteLine("Full outer join : ");
            Console.WriteLine();

            var fullOuterJoin = leftJoin.Union(rightJoin);

            foreach (var item in fullOuterJoin)
            {
                Console.WriteLine(
                                "Player Name : " + item.Player + " -- " +
                                "Player Country : " + item.Country + " -- " +
                                "New Team : " + item.TransferClub
                                );
            }
        }
    }
}
