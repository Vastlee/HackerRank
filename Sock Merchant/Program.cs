using System;

namespace Sock_Merchant {
  internal static class Program {
    private static void Main(string[] args) {
      InputPair[] inputs = {
        new InputPair(7, new int[] { 1, 2, 1, 2, 1, 3, 2 }),
      };

      foreach(var input in inputs) {
        Console.WriteLine(Solution.sockMerchant(input.Count, input.Socks));
      }
    }

    private class InputPair {
      public InputPair(int count, int[] socks) {
        Count = count;
        Socks = socks;
      }

      public int Count { get; set; }
      public int[] Socks { get; set; }
    }
  }
}