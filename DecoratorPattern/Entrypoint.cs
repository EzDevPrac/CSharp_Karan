using System;

namespace DecoratorPattern{

public class EntryPoint

{
 public static void Main(string[] args)
 {
 // Basic vehicle
 Players player1 = new Players();
 MoreDetails playerInfo = new MoreDetails(player1);

 String name=player1.GetPlayerName();
 int age = player1.GetPlayerAge();
 String playerType=playerInfo.PlayerType();
 int RunsScored = player1.GetTotalRunsScored;
 int BallsFaced = player1.GetTotalBallsPlayed;
 double strikeRate = player1.GetPlayerStrikeRate();
 String PlayerNationality = playerInfo.PlayerNationality();

 
 Console.WriteLine("-------Player Information-----------------");
 Console.WriteLine("Player Name        : " + name);
 Console.WriteLine("Player Nationality : " + PlayerNationality);
 Console.WriteLine("Player Age         : " + age);
 Console.WriteLine("Player Type        : " + playerType);
 Console.WriteLine("Player Total Score : " + RunsScored);
 Console.WriteLine("Total Balls PLayed : " + BallsFaced);
 Console.WriteLine("Strike Rate        : " + strikeRate);
 Console.WriteLine("------------------------------------------");
 Console.ReadKey();

 }
}




}