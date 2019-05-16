using System;
using System.IO;

class Solution {
  #region Class Methods
  private static int formingMagicSquare(int[][] s) {
    int result = -1;

    return result;
  }

  private static int FindCommonSum(int[][] s) {
    int result = -1;
    int[] sums = new int[3];
    for(int i = 0; i < 3; i++) {

    }
    return result;
  }

  #endregion

  #region Main
  static void Main(string[] args) {
    TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    int[][] s = new int[3][];

    for(int i = 0; i < 3; i++) {
      s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
    }

    int result = formingMagicSquare(s);

    textWriter.WriteLine(result);

    textWriter.Flush();
    textWriter.Close();
  }
  #endregion
}