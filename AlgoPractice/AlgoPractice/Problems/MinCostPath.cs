using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
   public class MinCostPath: Problem, IDynamicProgrammingTopDown
   {
       #region Fields
       int[,] coordinates;
       int rows;
       int columns;
       int minCost= int.MaxValue;
       #endregion Fields

       /// <summary>
       /// Sets the input.
       /// </summary>
       /// <param name="inputCoordinates">The input coordinates.</param>
       /// <param name="inputRows">The input rows.</param>
       /// <param name="inputColoumns">The input coloumns.</param>
       public void SetInput(int[,] inputCoordinates, int inputRows,int inputColoumns)
       {
           coordinates = inputCoordinates;
           rows = inputRows;
           columns = inputColoumns;
       }

       /// <summary>
       /// Calculates the solution by top down.
       /// </summary>
       public void CalculateSolutionByTopDown()
        {
           minCost = Recursive(0, 0); 
        }

       /// <summary>
       /// Recursives the specified n.
       /// </summary>
       /// <param name="n">The n.</param>
       /// <param name="m">The m.</param>
       /// <returns></returns>
       private int Recursive( int n, int m)
       {
           int result = int.MaxValue;

           if (n+1 == rows && m+1 == columns)
           {
               result = coordinates[n,m];
           }
           else
           {
               int diagonal = int.MaxValue;
               int right = int.MaxValue;
               int down = int.MaxValue;

               if (n +1 < rows && m + 1 < columns)
               {
                   diagonal = Recursive(n + 1, m + 1);
               }
               if(n +1 < rows)
               {
                   down = Recursive(n + 1, m);
               }
               if (m+1 < columns)
               {
                   right = Recursive(n, m + 1);
               }

               result = Min(diagonal, right, down);

               if(result != int.MaxValue)
               {
                   result += coordinates[n,m];
               }
           }
           return result;
       }

       /// <summary>
       /// Minimums the specified diagonal.
       /// </summary>
       /// <param name="diagonal">The diagonal.</param>
       /// <param name="right">The right.</param>
       /// <param name="down">Down.</param>
       /// <returns></returns>
       private int Min(int diagonal, int right, int down)
       {
           return diagonal > right ? (right > down ? down : right) : (diagonal > down ? down : diagonal);
       }

       /// <summary>
       /// Verifies the with expected value.
       /// </summary>
       /// <param name="expected">The expected.</param>
       /// <returns></returns>
       public bool VerifyWithExpectedValue(int expected)
       {
           return minCost == expected;
       }
    }
}
