using System;
using System.IO;

namespace Birthday_Cake_Candles {
  internal static class Solution {
    private static int BirthdayCakeCandles(int[] ar) {
      int heighest = -1;
      int count = 0;

      for(int i = 0; i < ar.Length; i++) {
        if(ar[i] > heighest) {
          heighest = ar[i];
          count = 1;
        } else if(ar[i] == heighest) { count++; }
      }

      return count;
    }

    private static void Main(string[] args) {
      TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
      int arCount = Convert.ToInt32(Console.ReadLine());
      int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
      int result = BirthdayCakeCandles(ar);
      textWriter.WriteLine(result);
      textWriter.Flush();
      textWriter.Close();
    }
  }
}