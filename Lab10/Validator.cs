namespace Lab10
{
    public static class Validator
    {
        public static bool IsValidDouble(string strDouble)
        {
            double d;

            return double.TryParse(strDouble, out d);
        }
    }
}
