using System;
using System.IO;

namespace Forming_A_Magic_Square {
  internal static class Solution {
    private static readonly MagicSquare[] possibleSquares = new MagicSquare[] {
      new MagicSquare(new int[][] {
        new int[] { 8, 1, 6 },
        new int[] { 3, 5, 7 },
        new int[] { 4, 9, 2 }
        }),
      new MagicSquare(new int[][] {
        new int[] { 6, 1, 8 },
        new int[] { 7, 5, 3 },
        new int[] { 2, 9, 4 }
        }),
      new MagicSquare(new int[][] {
        new int[] { 4, 9, 2 },
        new int[] { 3, 5, 7 },
        new int[] { 8, 1, 6 }
        }),
      new MagicSquare(new int[][] {
        new int[] { 2, 9, 4 },
        new int[] { 7, 5, 3 },
        new int[] { 6, 1, 8 }
        }),
      new MagicSquare(new int[][] {
        new int[] { 8, 3, 4 },
        new int[] { 1, 5, 9 },
        new int[] { 6, 7, 2 }
        }),
      new MagicSquare(new int[][] {
        new int[] { 4, 3, 8 },
        new int[] { 9, 5, 1 },
        new int[] { 2, 7, 6 }
        }),
      new MagicSquare(new int[][] {
        new int[] { 6, 7, 2 },
        new int[] { 1, 5, 9 },
        new int[] { 8, 3, 4 }
        }),
      new MagicSquare(new int[][] {
        new int[] { 2, 7, 6 },
        new int[] { 9, 5, 1 },
        new int[] { 4, 3, 8 }
        })
      };

    #region Class Methods
    private static int FormingMagicSquare(int[][] s) {
      int leastChanged = int.MaxValue;
      int changesNeeded;

      foreach(MagicSquare possible in Solution.possibleSquares) {
        changesNeeded = 0;
        for(int i = 0; i < possible.Square.Length; i++) {
          for(int i2 = 0; i2 < possible.Square[i].Length; i2++) {
            if(possible.Square[i][i2] != s[i][i2]) {
              changesNeeded += Math.Abs(possible.Square[i][i2] - s[i][i2]);
            }
          }
        }

        if(changesNeeded < leastChanged) {
          leastChanged = changesNeeded;
        }

      }
      return leastChanged;
    }

    #endregion Class Methods

    #region Structs
    internal struct MagicSquare {
      public int[][] Square { get; }

      internal MagicSquare(int[][] square) => Square = square;
    }
    #endregion

    #region Main
    private static void Main(string[] args) {
      TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      int[][] s = new int[3][];
      for(int i = 0; i < 3; i++) {
        s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
      }

      int result = FormingMagicSquare(s);

      textWriter.WriteLine(result);
      textWriter.Flush();
      textWriter.Close();
    }
    #endregion Main
  }
}