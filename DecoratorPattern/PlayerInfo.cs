using System;

namespace DecoratorPattern{
//Decorator Class
public abstract class PlayerInfo:IPlayer{

private IPlayer _IPlayer;

public PlayerInfo(IPlayer player)
{

    this._IPlayer = player;
}public virtual string GetPlayerName(){

    return this._IPlayer.GetPlayerName();
}

public virtual int GetPlayerAge(){

    return this._IPlayer.GetPlayerAge();
}

public virtual int GetTotalBallsPlayed{
    get{

    return this._IPlayer.GetTotalBallsPlayed;}

    set{}
    
}
public virtual int GetTotalRunsScored{
  get {
    return this._IPlayer.GetTotalRunsScored;
  }
}

public virtual double GetPlayerStrikeRate(){

    return this._IPlayer.GetPlayerStrikeRate();
}

}



}