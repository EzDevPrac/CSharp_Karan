using System;

namespace DecoratorPattern
{ //component interface
    public interface IPlayer{

        string PlayerName{get;set;}
        int PlayerAge{get;set;}

        float PlayerStrikeRate{get;set;}
        int TotalBallsPlayed{get;set;}
        int TotalRunsScored{get; set;}





    }
    
}
