using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace leetcode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LongestCommonPrefix(new string[] { "acc", "aaa", "aaba" }));
        }

        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (strs == null || strs.Length == 0)
                {
                    return "";
                }

                // Sort the array
                Array.Sort(strs);

                // The first and the last string after sorting
                string firstStr = strs[0];
                string lastStr = strs[strs.Length - 1];

                int i = 0;
                while (i < firstStr.Length && i < lastStr.Length && firstStr[i] == lastStr[i])
                {
                    i++;
                }

                return firstStr.Substring(0, i);
            }
        }
    }
}
