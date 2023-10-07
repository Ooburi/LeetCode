using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1420. Build Array Where You Can Find The Maximum Exactly K Comparisons
    //You are given three integers n, m and k.Consider the following algorithm to find the
    //maximum element of an array of positive integers:
    //  max_value = -1;
    //  max_index = -1
    //  search_cost = 0
    //  n = arr.length
    //  for(i=0;i<n;i++){
    //      if(max_value<arr[i]){
    //          max_value = arr[i]
    //          max_index = i
    //          search_cost++
    //      }
    //  }
    //return max_index

    //You should build the array arr which has the following properties:
    //  arr has exactly n integers.
    //  1 <= arr[i] <= m where(0 <= i<n).
    //  After applying the mentioned algorithm to arr, the value search_cost is equal to k.
    //  Return the number of ways to build the array arr under the mentioned conditions.
    //  As the answer may grow large, the answer must be computed modulo 109 + 7.
    internal class _1420_
    {
        public int NumOfArrays(int n, int m, int k)
        {
            const int mod = 1000000007;

            int[][] dp = new int[m + 1][];
            int[][] prefix = new int[m + 1][];
            int[][] prevDp = new int[m + 1][];
            int[][] prevPrefix = new int[m + 1][];

            for (int i = 0; i <= m; i++)
            {
                dp[i] = new int[k + 1];
                prefix[i] = new int[k + 1];
                prevDp[i] = new int[k + 1];
                prevPrefix[i] = new int[k + 1];
            }

            for (int j = 1; j <= m; j++)
            {
                prevDp[j][1] = 1;
                prevPrefix[j][1] = j;
            }

            for (int i = 2; i <= n; i++)
            {
                for (int maxNum = 1; maxNum <= m; maxNum++)
                {
                    for (int cost = 1; cost <= k; cost++)
                    {
                        dp[maxNum][cost] = (int)(((long)maxNum * prevDp[maxNum][cost]) % mod);

                        if (maxNum > 1 && cost > 1)
                        {
                            dp[maxNum][cost] = (dp[maxNum][cost] + prevPrefix[maxNum - 1][cost - 1]) % mod;
                        }

                        prefix[maxNum][cost] = (prefix[maxNum - 1][cost] + dp[maxNum][cost]) % mod;
                    }
                }

                for (int j = 1; j <= m; j++)
                {
                    Array.Copy(dp[j], prevDp[j], k + 1);
                    Array.Copy(prefix[j], prevPrefix[j], k + 1);
                }
            }

            return prefix[m][k];
        }
    }
}
