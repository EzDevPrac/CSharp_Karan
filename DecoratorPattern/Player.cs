using System;

namespace DecoratorPattern
{ //component interface
    public interface IPlayer{

        string GetPlayerName();
        int GetPlayerAge();

        double GetPlayerStrikeRate();
        int GetTotalBallsPlayed{get;set;}
        int GetTotalRunsScored{get;}





    }
    
}
