using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roshambo.Models;

namespace Roshambo.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceofGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
    [TestMethod]
    public void DetermineWinner_ReturnsResult_String()
    {
      string player1Answer = "rock";
      string player2Answer = "paper";
      string result = Game.DetermineWinner(player1Answer, player2Answer);
      Assert.AreEqual(typeof(string), result.GetType());
    }
    [TestMethod]
    public void DetermineWinner_PaperBeatsRock_Player2Wins()
    {
      string player1Answer = "rock";
      string player2Answer = "paper";
      string result = Game.DetermineWinner(player1Answer, player2Answer);
      Assert.AreEqual("Player 2 Wins!", result);
    }
    [TestMethod]
    public void DetermineWinner_RockBeatsScissors_Player1Wins()
    {
      string player1Answer = "rock";
      string player2Answer = "scissors";
      string result = Game.DetermineWinner(player1Answer, player2Answer);
      Assert.AreEqual("Player 1 Wins!", result);
    }
    [TestMethod]
    public void DetermineWinner_ScissorsBeatsPaper_Player1Wins()
    {
      string player1Answer = "scissors";
      string player2Answer = "paper";
      string result = Game.DetermineWinner(player1Answer, player2Answer);
      Assert.AreEqual("Player 1 Wins!", result);
    }
    [TestMethod]
    public void DetermineWinner_PaperDrawsPaper_Draw()
    {
      string player1Answer = "paper";
      string player2Answer = "paper";
      string result = Game.DetermineWinner(player1Answer, player2Answer);
      Assert.AreEqual("Draw!", result);
    }
    [TestMethod]
    public void DetermineWinner_NonsenseWords_Retry()
    {
      string player1Answer = "chainsaw";
      string player2Answer = "finger guns";
      string result = Game.DetermineWinner(player1Answer, player2Answer);
      Assert.AreEqual("wut", result);
    }
  }
}