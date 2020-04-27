using Xunit;
using DecoratorPattern;

namespace DecoratorrPattern.Test
{  
    public class CheckPlayers
    {
     Players player = new Players();
         
     [Fact]
     public void CheckThePlayerAge()
     {  
     
        player.PlayerAge =10;
        Assert.Equal(10,player.PlayerAge);
     }
     [Fact]
     public void CheckThePlayerNameAsKaran()
     {
        player.PlayerName = "Karan";
        Assert.Equal("Karan",player.PlayerName);
     }

     [Theory]
     [InlineData(100,100)]
     [InlineData(120,120)]
     public void CheckThePlayerScore(int runs,int  Solution){
              
         player.TotalRunsScored = runs;
         //int RunsScored = player.TotalRunsScored;
         Assert.Equal(player.TotalRunsScored,Solution);
     }

     [Theory]
     [InlineData("All Rounder","All Rounder")]
     [InlineData("Batsman","Batsman")]
     [InlineData("Bowler","Bowler")]
      public void CheckPlayerType(string type,string Solution)
     {
        MoreDetails details =new MoreDetails(player) ;
        details.PlayerType= type; 
        Assert.Equal(details.PlayerType,Solution);
     }

     [Theory]
     [InlineData("Indian","Indian")]
     [InlineData("Australian","Australian")]
     [InlineData("South African","South African")]
      public void CheckPlayerNatinality(string Nation,string Solution)
     {
        MoreDetails details =new MoreDetails(player) ;
        details.PlayerNationality = Nation; 
        Assert.Equal(details.PlayerNationality,Solution);
     }     

    }
}
