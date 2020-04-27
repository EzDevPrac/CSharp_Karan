using System;

namespace DecoratorPattern{

//Concrete Decorator

public class MoreDetails:PlayerInfo{
    public MoreDetails(IPlayer iPlayer):base(iPlayer){}
    string _PlayerType,_Nationality;
  public string PlayerType{
       get{return _PlayerType;}
       set{_PlayerType =value;}

    }
  public string PlayerNationality{
      get{
      return _Nationality;}
      set{ _Nationality =value;}
    }     

   public void moreDetails(){

     Console.WriteLine("Enter the player Type(All Rounder/Batsman/Bowler)");
     _PlayerType = Console.ReadLine();
     Console.WriteLine("Enter the Player Nationality");
     _Nationality = Console.ReadLine();
      
       
    }
 
 }

}