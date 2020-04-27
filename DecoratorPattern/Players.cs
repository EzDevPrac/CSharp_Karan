using System;

namespace DecoratorPattern{

//Concrete Component
public class Players:IPlayer{
   public int _BallsPlayed,_PlayerAge,_TotalRunsScored;
   public string _PlayerName;

   public float _StrikeRate;
   public String PlayerName{
   get{
   return  _PlayerName;
   }
   set {
         
     _PlayerName =value;
   }   
   }
   public int TotalBallsPlayed{
  
    get{ 
        return _BallsPlayed;}

    set {

         _BallsPlayed =value;}    
    }

   public int TotalRunsScored{
       get{
           return _TotalRunsScored;}
       set{
           _TotalRunsScored = value;
       }    
   }
   
   public int PlayerAge{
         get{       
           return _PlayerAge;}
        set{
           _PlayerAge = value;} 
   }         
   public float PlayerStrikeRate{
       get{
       _StrikeRate = (_TotalRunsScored/_BallsPlayed)*100;

       return _StrikeRate;}

       set{}
    }

    public void GetDetails(){
    
    Console.WriteLine("Enter the player  name :");
     _PlayerName = Console.ReadLine();
    Console.WriteLine("Enter the no of Balls Faced by the player");
     _BallsPlayed = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter the total runs Scored");
     _TotalRunsScored = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter the Player Age");
     _PlayerAge = Convert.ToInt16(Console.ReadLine());
    }
    

}
}
