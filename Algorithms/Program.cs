using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ex1 = "123456789-0=qwertyuiop[]asdfghjkl;'zxcvbnm,./1dasda";
            string ex2 = "sad";

            //PerformanceMonitor.GetMilliseconds(1, 100, () => ex1.IsCharsUnique(), () => ex1.IsCharsUniqueINDEXOF(), () => ex1.IsCharsUniqueLINQ());

            //Console.WriteLine();

            //PerformanceMonitor.Run(100, () => ex1.IsCharsUniqueLINQ());


            //Console.WriteLine($"Removed duplicated chars in '{ex1}': {ex1.RemoveDuplicateChars()}");

            //Console.WriteLine($"{ex1} and {ex2} are anagrams: {ex1.IsAnagram(ex2)}");
            //Console.WriteLine($"{ex1} and {ex2} are anagrams: {ex1.IsAnagramLINQ(ex2)}");

            //Console.WriteLine($"{ex1} reversed is: {ex1.ReverseStr()}");

            //Console.WriteLine($"{ex1} has {ex1.CountWord()} words");

            //Console.WriteLine($"{ex1} palindrome: {ex1.IsPalindrome()}");

            //Console.WriteLine($"Most used char in {ex1} is: {ex1.CharMostUsed()}");
            //Console.WriteLine($"Most used char in {ex1} is: {ex1.CharMostUsedLINQ()}");

            //Console.WriteLine($"All chars in {ex1} are unique: {ex1.IsCharsUnique()}");
            //Console.WriteLine($"All chars in {ex1} are unique: {ex1.IsCharsUniqueINDEXOF()}");
            //Console.WriteLine($"All chars in {ex1} are unique: {ex1.IsCharsUniqueLINQ()}");

            Console.ReadLine();            
        }
    }
}
