using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixth_Practice.Digit
{
    public class Text
    {
        public string str = "abcd1234";
        public string onlyDigit;

        public string Get()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i])) { onlyDigit += str[i]; }
            }
            return onlyDigit;
        }
    }
}
