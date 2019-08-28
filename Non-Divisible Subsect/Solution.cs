using System;
using System.IO;

namespace Non_Divisible_Subsect {
  internal static class Solution {
    private static int NonDivisibleSubset(int k, int[] arr) {
      int[] remains = new int[k];
      int result = 0;

      for(int i = 0; i < arr.Length; i++) { remains[arr[i] % k]++; }

      if(remains[0] > 0) { result++; }

      for(int i = 1; i < remains.Length; i++) {
        if(i == (k - i)) {
          result++;
        } else {
          if(remains[i] >= remains[k - i]) {
            result += remains[i];
          } else {
            result += remains[k - i];
          }
          remains[i] = 0;
          remains[k - i] = 0;
        }
      }
      return result;
    }

    private static void Main(string[] args) {
      TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      string[] nk = Console.ReadLine().Split(' ');

      int n = Convert.ToInt32(nk[0]);

      int k = Convert.ToInt32(nk[1]);

      int[] S = Array.ConvertAll(Console.ReadLine().Split(' '), STemp => Convert.ToInt32(STemp))
      ;
      int result = NonDivisibleSubset(k, S);

      textWriter.WriteLine(result);

      textWriter.Flush();
      textWriter.Close();
    }
  }
}