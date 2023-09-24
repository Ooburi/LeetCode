using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //799. Champagne Tower
    //    We stack glasses in a pyramid,
    //    where the first row has 1 glass, the second row has 2 glasses,
    //    and so on until the 100th row.Each glass holds one cup of champagne.


    //    Then, some champagne is poured into the first glass at the top.
    //    When the topmost glass is full, any excess liquid poured will fall
    //    equally to the glass immediately to the left and right of it.
    //    When those glasses become full, any excess champagne will fall equally to the left and right
    //    of those glasses, and so on.  (A glass at the bottom row has its excess champagne fall on the floor.)

    //For example, after one cup of champagne is poured,
    //the top most glass is full.After two cups of champagne are poured,
    //the two glasses on the second row are half full.After three cups of champagne
    //are poured, those two cups become full - there are 3 full glasses total now.
    //After four cups of champagne are poured, the third row has the middle glass half full,
    //and the two outside glasses are a quarter full, as pictured below.
    internal class _799_ChampagneTower
    {
        public static double ChampagneTower(int poured, int query_row, int query_glass)
        {

            // MY VERY SLOW SOLUTION
            //double[][] cups = new double[100][];
            //for (int i = 0; i < cups.Length; i++)
            //{
            //    cups[i] = new double[i + 1];
            //}
            //pourChampagne(0, 0, poured);

            //void pourChampagne(int i, int j, double amount)
            //{
            //    if (i > query_row) return;
            //    cups[i][j] += amount;
            //    if (cups[i][j] > 1)
            //    {
            //        double half = ((1d - cups[i][j]) * (-1d)) / 2d;
            //        cups[i][j] = 1;
            //        pourChampagne(i + 1, j, half);
            //        pourChampagne(i + 1, j + 1, half);
            //    }
            //}

            //return cups[query_row][query_glass];


            // MY NOT So Slow Solution
            double[][] cups = new double[100][];
            for (int i = 0; i < cups.Length; i++)
            {
                cups[i] = new double[i + 1];
            }
            cups[0][0] = poured;
            for (int i = 0; i <= query_row; i++)
            {
                for (int j = 0; j < cups[i].Length; j++)
                {
                    if (cups[i][j] > 1d)
                    {
                        double half = ((1d - cups[i][j]) * (-1d)) / 2d;
                        cups[i][j] = 1;
                        cups[i + 1][j] += half;
                        cups[i + 1][j + 1] += half;
                    }
                }
            }


            return cups[query_row][query_glass];

            // JUST WRONG
            //double[] currentRow = new double[query_row + 2];
            //double[] nextRow = new double[query_row + 2];
            //currentRow[0] = poured;

            //int rowNumber = 1;

            //for (int i = 0; i <= query_row; i++)
            //{
            //    int stat=0;
            //    for (int j = 0; j < rowNumber; j++)
            //    {
            //        if (currentRow[j] > 1d)
            //        {
            //            double half = ((1d - currentRow[j]) * (-1d)) / 2d;
            //            currentRow[j] = 1;
            //            nextRow[j] += half;
            //            nextRow[j + 1] += half;
            //        }
            //    }
            //    for (int k = 0; k <= query_row; k++)
            //    {
            //        currentRow[k] = nextRow[k];
            //        nextRow[k] = 0d;
            //    }
            //    rowNumber++;
            //}


            //return currentRow[query_glass];

        }
    }
}
