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

    public enum Strategy
    {
        X, //lose
        Y, //draw
        Z  //win
    }
    public class Day2
    {
        public int StrategyTwo(string[] input)
        {
            int totalScore = 0;

            foreach(string row in input)
            {
                var item = row.Split(" ");

                var player1 = Enum.Parse<Player1>(item[0].ToString());
                var strategy = Enum.Parse<Strategy>(item[1].ToString());

                var p1 = (int)player1;

                if (strategy == Strategy.Y) //draw
                {
                    totalScore += p1 + 3;
                }
                else if (strategy == Strategy.Z) //win
                {
                    totalScore += 6;
                    switch(player1)
                    {
                        case Player1.A:
                            totalScore += (int)Player2.Y;
                            break;
                        case Player1.B:
                            totalScore += (int)Player2.Z;
                            break;
                        case Player1.C:
                            totalScore += (int)Player2.X;
                            break;
                    }
                }
                else //lose
                {
                    switch (player1)
                    {
                        case Player1.A:
                            totalScore += (int)Player2.Z;
                            break;
                        case Player1.B:
                            totalScore += (int)Player2.X;
                            break;
                        case Player1.C:
                            totalScore += (int)Player2.Y;
                            break;
                    }
                }
            }
            return totalScore;
        }

        public int StrategyOne(string[] input)
        {
            int totalScore = 0;
            foreach(string row in input)
            {
                var item = row.Split(" ");

                var player1 = Enum.Parse<Player1>(item[0].ToString());
                var player2 = Enum.Parse<Player2>(item[1].ToString());

                var p1 = (int)player1;
                var p2 = (int)player2;

                var win1 = player1 == Player1.A && player2 == Player2.Y;
                var win2 = player1 == Player1.B && player2 == Player2.Z;
                var win3 = player1 == Player1.C && player2 == Player2.X;

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
