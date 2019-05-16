using System;

namespace Solve_Me_First {
  internal static class Solution {
    private static int SolveMeFirst(int a, int b) => (a + b);

    private static void Main(String[] args) {
      int val1 = Convert.ToInt32(Console.ReadLine());
      int val2 = Convert.ToInt32(Console.ReadLine());
      int sum = SolveMeFirst(val1, val2);
      Console.WriteLine(sum);
    }
  }
}