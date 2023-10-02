using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //2038. Remove Colored Pieces if Both Neighbors are the Same Color
    //There are n pieces arranged in a line, and each piece is colored
    //either by 'A' or by 'B'. You are given a string colors of length n where colors[i]
    //is the color of the ith piece.

    //Alice and Bob are playing a game where they take alternating turns removing pieces
    //from the line. In this game, Alice moves first.

    //Alice is only allowed to remove a piece colored 'A' if both its neighbors are also colored 'A'.
    //She is not allowed to remove pieces that are colored 'B'.
    //Bob is only allowed to remove a piece colored 'B' if both its neighbors are also colored 'B'.
    //He is not allowed to remove pieces that are colored 'A'.
    //Alice and Bob cannot remove pieces from the edge of the line.
    //If a player cannot make a move on their turn, that player loses and the other player wins.
    //Assuming Alice and Bob play optimally, return true if Alice wins, or return false if Bob wins.
    internal class _2038_
    {
        public static bool WinnerOfGame(string colors)
        {
            // TIME LIMIT EXCEEDED
            //StringBuilder sb = new StringBuilder(colors);
            //int i = 0;
            //while(sb.Length > 0)
            //{
            //    i = sb.ToString().IndexOf("AAA");
            //    if (i>=0)
            //    {
            //        sb.Remove(i + 1, 1);
            //    } else return false;
            //    i = sb.ToString().IndexOf("BBB");
            //    if (i >= 0)
            //    {
            //        sb.Remove(i + 1, 1);
            //    }
            //    else return true;
            //}
            //return false;
            int indexA = 0,indexB=0;
            int countA=0,countB=0;
            
            while(indexA!=-1)
            {
                int i = colors.IndexOf("AAA", indexA);
                if (i != -1)
                {
                    indexA = i + 1;
                    countA++;
                }
                else indexA = -1;
            }

            while (indexB != -1)
            {
                int j = colors.IndexOf("BBB", indexB);
                if (j != -1)
                {
                    indexB = j + 1;
                    countB++;
                }
                else indexB = -1;
            }
            return countA > countB;
            
        }
    }
}
