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

    //https://www.hackerrank.com/challenges/one-month-preparation-kit-sum-vs-xor

    public static long sumXor(long n)
    {
        if (n == 0) return 1;

        var bits = Convert.ToString(n, 2).ToCharArray().ToList();
        var zeros = bits.Where(b => b == '0').Count();

        return Convert.ToInt64(Math.Pow(2, zeros));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.sumXor(n);

        Console.WriteLine(result);
    }
}
