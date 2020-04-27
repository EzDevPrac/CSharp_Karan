using System;

namespace DecoratorPattern{

public class EntryPoint

{
 public static void Main(string[] args)
 {
 // Basic vehicle
 Players player1 = new Players();
 MoreDetails playerInfo = new MoreDetails(player1);
 player1.GetDetails();
 playerInfo.moreDetails();

 
 Console.WriteLine("-------Player Information-----------------");
 Console.WriteLine("Player Name        : " + playerInfo.PlayerName);
 Console.WriteLine("Player Nationality : " + playerInfo.PlayerNationality);
 Console.WriteLine("Player Age         : " + playerInfo.PlayerAge);
 Console.WriteLine("Player Type        : " + playerInfo.PlayerType);
 Console.WriteLine("Player Total Score : " + playerInfo.TotalRunsScored);
 Console.WriteLine("Total Balls PLayed : " + playerInfo.TotalBallsPlayed);
 Console.WriteLine("Strike Rate        : " + playerInfo.PlayerStrikeRate);
 Console.WriteLine("------------------------------------------");
 Console.ReadKey();

 }
}




}