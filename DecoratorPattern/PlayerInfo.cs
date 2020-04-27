using System;

namespace DecoratorPattern{
//Decorator Class
public abstract class PlayerInfo:IPlayer{

        private IPlayer _IPlayer;

        public PlayerInfo(IPlayer player)
{

    this._IPlayer = player;
}
        public virtual string PlayerName{

   get{
    return this._IPlayer.PlayerName;}
   set{}
}

        public virtual int PlayerAge{
   get{
    return this._IPlayer.PlayerAge;}
   set{}
}

        public virtual int TotalBallsPlayed{
    get{
    return this._IPlayer.TotalBallsPlayed;}
    set{}
    
}
        public virtual int TotalRunsScored{
  get {
    return this._IPlayer.TotalRunsScored;
  }
  set{}
}

        public virtual float PlayerStrikeRate{
    get{
    return this._IPlayer.PlayerStrikeRate;}
    set{}
}

}



}