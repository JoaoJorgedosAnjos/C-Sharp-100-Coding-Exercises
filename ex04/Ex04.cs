using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static List<string> GetQualifiedPlayers(
            Dictionary<string, int> playerScores)
        {
            //your code goes here
            List<string> players =new List<string>();
            foreach(var player in playerScores){
                if(player.Value < 100 && player.Value >= 50){
                    players.Add(player.Key);
                }
                else if(player.Value >= 100){
                    break;
                }
            }
            return players;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static List<string> GetQualifiedPlayers(
            Dictionary<string, int> playerScores)
        {
            //your code goes here
            const int MinimumScore = 50;
            const int CheatingScore = 100;

            return playerScores
                        .TakeWhile(playerScore => playerScore.Value < CheatingScore)
                        .Where(playerScore => playerScore.Value >= MinimumScore)
                        .Select(playerScore => playerScore.Key)
                        .ToList();
        }
    }
}

/*

*/