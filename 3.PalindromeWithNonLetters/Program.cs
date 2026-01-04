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

    /*
     * Complete the 'isAlphabeticPalindrome' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING code as parameter.
     */

    public static bool isAlphabeticPalindrome(string? code)
    {
        if(String.IsNullOrEmpty(code)){return false;}
        
        code = code.ToLower();
        char[] codeArray=code.Where(char.IsLetter).ToArray(); 
        string rightToLeft="";
        string leftToRight = new string(codeArray);

        for(int i = codeArray.Length-1;i>=0;i--){
            rightToLeft += codeArray[i];
        }
        return leftToRight==rightToLeft;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Write a palindrome... or not?");
        Console.WriteLine("Special Characters and numbers will be discarded");
        Console.WriteLine("Example: typed: A1b2B!a -> this will validate 'abba'");
        Console.Write(">");

        string? code = Console.ReadLine();

        bool result = Result.isAlphabeticPalindrome(code);

        Console.WriteLine((result ? 1 : 0));
    }
}
