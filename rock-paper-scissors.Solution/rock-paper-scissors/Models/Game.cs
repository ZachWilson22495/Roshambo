namespace Roshambo.Models
{
  public class Game
  {
    public static string DetermineWinner(string answer1, string answer2)
    {
      string result = "";
      if (answer1 == answer2)
      {
        result = "Draw!";
      }
      else if (answer1 == "rock" && answer2 == "paper" || answer1 == "paper" && answer2 == "scissors" || answer1 == "scissors" && answer2 == "rock") 
      {
        result = "Player 2 Wins!";
      }
      else if (answer1 == "rock" && answer2 == "scissors" || answer1 == "paper" && answer2 == "rock" || answer1 == "scissors" && answer2 == "paper")
      {
        result = "Player 1 Wins!";
      } else {
        result = "wut";
      }
      
      return result;
    }
  }
}
