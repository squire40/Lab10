using System.Collections.Generic;

namespace Lab10
{
    public static class Validator
    {
        private static List<string> _validValues = new List<string>{ "y", "n" };
        public static bool IsValidDouble(string strDouble)
        {
            double d;

            return double.TryParse(strDouble, out d);
        }

        public static bool IsYesOrNo(string input)
        {
            return _validValues.Contains(input.ToLower());
        }
    }
}
