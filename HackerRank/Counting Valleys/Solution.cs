using System;
using System.IO;

namespace Counting_Valleys {

  internal static class Solution {

    private static int countingValleys(int n, string s) {
      int level = 0;
      int stepDir;
      int valleyCount = 0;

      for(int i = 0; i < s.Length - 1; i++) {
        stepDir = (s[i] == 'U') ? 1 : -1;
        if((level >= 0) && (level + stepDir) < 0) {
          valleyCount++;
        }
        level += stepDir;
      }

      return valleyCount;
    }

    private static void Main(string[] args) {
      TextWriter textWriter = new StreamWriter(@Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      int n = Convert.ToInt32(Console.ReadLine());

      string s = Console.ReadLine();

      int result = countingValleys(n, s);

      textWriter.WriteLine(result);

      textWriter.Flush();
      textWriter.Close();
    }
  }
}