using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryrarbiL
{
    public class PalendromeCheker: ICheckPalindrome
    {
        public bool IsPalendrome(string x)
        {
            return RegString(x) == RegString(ReverseString(x));
        }

        private string ReverseString(string x)
        {
            string output = "";
            for (int i = x.Length - 1; i >= 0; i--) output += x[i];
            return output;
        }

        private string RegString(string x)
        {
            string output = "";
            for (int i = 0; i < x.Length; i++)
            {
                char k = x[i];
                if ((k <= 'z' && k >= 'a') || (k <= 'Z' && k >= 'A')) output += k;
            }
            return output.ToUpper();
        }
    }
}
