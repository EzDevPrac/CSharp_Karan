using System;

namespace DecoratorPattern{

//Concrete Component
public class Players:IPlayer{
   public int _BallsPlayed;
   public   int _TotalRunsScored;
   public String GetPlayerName(){
   
   Console.WriteLine("Enter the player  name :");
   string  PlayerName = Console.ReadLine();
   return  PlayerName;
   }
   public int GetTotalBallsPlayed{
  
    get{ 
        Console.WriteLine("Enter the no of Balls Faced by the player");
       _BallsPlayed = Convert.ToInt16(Console.ReadLine());
        return _BallsPlayed;}

    set {}    
    }

   public int GetTotalRunsScored{
       get{
   Console.WriteLine("Enter the total runs Scored");
  _TotalRunsScored = Convert.ToInt16(Console.ReadLine());
   
   return _TotalRunsScored;}
   }
   public int GetPlayerAge(){

       Console.WriteLine("Enter the Player Age");
       int PlayerAge = Convert.ToInt16(Console.ReadLine());
      
      return PlayerAge;
   }
   public double GetPlayerStrikeRate(){
       
       double strikeRate = (_TotalRunsScored/_BallsPlayed)*100;

       return strikeRate; 
    }
    

}



}
