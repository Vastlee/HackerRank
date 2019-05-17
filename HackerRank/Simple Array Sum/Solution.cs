using System;

namespace Simple_Array_Sum {
  internal static class Solution {

    private static int SimpleArraySum(int[] ar) {
      int result = 0;
      foreach(int e in ar) {
        result += e;
      }
      return result;
    }

    private static void Main(string[] args) {
      int arCount = Convert.ToInt32(Console.ReadLine());
      int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
      int result = SimpleArraySum(ar);
      Console.WriteLine(result);
    }
  }
}