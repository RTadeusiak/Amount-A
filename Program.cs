using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static long repeatedString(string s, long n)
    {
        long countA = 0;
        long repetitions = n / s.Length;  
        long remainingChars = n % s.Length; 

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                countA += repetitions;
                if (i < remainingChars) 
                {
                    countA++;
                }
            }
        }
        return countA;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        Console.WriteLine(result);

    }
}
