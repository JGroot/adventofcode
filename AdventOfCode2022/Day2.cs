using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2022
{
    public enum Player1
    {
        A = 1, //rock
        B = 2, //paper
        C = 3  //scissors
    }

    public enum Player2
    {
        X = 1, //rock
        Y = 2, //paper
        Z = 3  //scissors
    }
    public class Day2
    {
        public int TotalScore(string[] input)
        {
            /// x = rock = 1
            /// y paper = 2
            /// z scissors = 1
            int totalScore = 0;
            foreach(string row in input)
            {
                var item = row.Split(" ");

                var player1 = Enum.Parse<Player1>(item[0].ToString());
                var player2 = Enum.Parse<Player2>(item[1].ToString());

                var p1 = (int)player1;
                var p2 = (int)player2;

                //if (p1 > p2) //lose
                //{
                //    totalScore += p2;
                //}
                //else if (p1 < p2) //win
                //{
                //    totalScore += p2 + 6;
                //}
                //else //draw
                //{
                //    totalScore += p2 + 3;
                //}

                var win1 = player1 == Player1.A && player2 == Player2.Y;
                var win2 = player1 == Player1.B && player2 == Player2.Z;
                var win3 = player1 == Player1.C && player2 == Player2.X;

                var lose1 = player1 == Player1.A && player2 == Player2.Z;
                var lose2 = player1 == Player1.B && player2 == Player2.X;
                var lose3 = player1 == Player1.C && player2 == Player2.Y;

                if (p1 == p2)
                {
                    totalScore += p2 + 3;
                }
                else if (win1 || win2 || win3)
                {
                    totalScore += p2 + 6;
                }
                else
                {
                    totalScore += p2;
                }
            }

            return totalScore;
        }
    }
}
