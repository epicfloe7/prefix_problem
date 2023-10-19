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
                int min_length;
                int j = 0;
                string letter_sum = "";

                if (strs.Length > 1)
                {
   bool is_breaked = false;  
                    
                   
                   min_length = strs.Min(y=> y.Length); 

                        for (int i = 0; i < strs.Length - 1; i+=0)
                        {
                            for (int jj = 0; jj <= min_length - 1; jj++)
                            {

                                if (i == strs.Length - 2)
                                {
                                    if (strs[i][j] == strs[i + 1][j])
                                    {
                                        letter_sum += strs[i][j];
                                        j++;
                                    i = 0;
                                   
                                    break;
                                    }

                                    else
                                    {
                                    is_breaked = true;
                                        break;
                                    }
                                }

                                else
                                {

                                    if (strs[i][j] == strs[i + 1][j])
                                    {
                                    i += 1;
                                    break;
                                    
                                    }
                                    else
                                    {
                                    is_breaked = true;
                                        break;
                                    }
                                }

                            }

                        if (is_breaked)
                        {
                            break;
                        }
                        }
                    

                }
                else
                {
                    letter_sum += strs[0];
                }
                return letter_sum;




            }
        }
    }


}
