using System.Globalization;
using Digit = Sixth_Practice.Digit;
using Letter = Sixth_Practice.Letter;
using System.Diagnostics;

namespace Sixth_Practice
{
    class Program
    {
        static void Main()
        {
            Digit.Text digit = new Digit.Text();
            Letter.Text letter = new Letter.Text();
            Console.WriteLine($"Digits: {digit.Get()}\nLetter: {letter.Get()}");
        }
    }
}

