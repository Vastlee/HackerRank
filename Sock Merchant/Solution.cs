using System.Collections.Generic;

namespace Sock_Merchant {
  internal static class Solution {
    internal static int sockMerchant(int n, int[] ar) {
      int result = 0;
      var socks = new Dictionary<int, int>();

      for(int i = 0; i < ar.Length; i++) {
        if(socks.ContainsKey(ar[i])) {
          socks[ar[i]]++;
        } else {
          socks.Add(ar[i], 1);
        }
      }

      foreach(KeyValuePair<int, int> sock in socks) {
        result += sock.Value / 2;
      }

      return result;
    }
  }
}