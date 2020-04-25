using System;

namespace DecoratorPattern{

//Concrete Decorator

public class MoreDetails:PlayerInfo{
    public MoreDetails(IPlayer iPlayer):base(iPlayer){}

   public string PlayerType(){
       Console.WriteLine("Enter the player Type(All Rounder/Batsman/Bowler)");
       string PlayerType = Console.ReadLine();
       return PlayerType;}

  public string PlayerNationality(){

      Console.WriteLine("Enter the Player Nationality");
      String Nationality = Console.ReadLine();
      return Nationality;
    }     

 }

}