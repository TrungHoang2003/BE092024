using DataAccess;
using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Common
{
    public class ValidateData
    {
        public static int checkSo(int n)
        {
            if (int.TryParse(Console.ReadLine(), out n) == true)
                return (int)Error.Is_Number;
            return (int)Error.Not_Number;
        }

        public static int checkSo(double n)
        {
            if (double.TryParse(Console.ReadLine(), out n) == true)
                return (int)Error.Is_Number;
            return (int)Error.Not_Number;

        }

        public int checkSo(float n)
        {
            if (Single.TryParse(Console.ReadLine(), out n) == true)
                return (int)Error.Is_Number;
            return (int)Error.Not_Number;

        }

        static bool ContainsSpecialChars(string input)
        {
            string specialCharPattern = @"[^a-zA-Z0-9\s]";
            bool hasSpecialChars = Regex.IsMatch(input, specialCharPattern);
            return hasSpecialChars;
        }
        static bool ContainsHtml(string input)
        {
            string htmlTagPattern = @"<.*?>";
            bool hasHtmlTags = Regex.IsMatch(input, htmlTagPattern);
            return hasHtmlTags;
        }


        public static int checkChuoi(string n)
        {
            if (string.IsNullOrEmpty(n))
                return (int)Error.String_Empty;
            else if (ContainsSpecialChars(n) == true)
                return (int)Error.String_Have_SpeicalChars;
            else if (ContainsHtml(n) == true)
                return (int)Error.String_Have_HTML;
            else
                return (int)Error.Valid_String;
        }
    }
}
