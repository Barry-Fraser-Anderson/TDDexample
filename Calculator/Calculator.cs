namespace Domain
{
    public class Calculator
    {
        public int Add(string value)
        {
            if (string.IsNullOrEmpty(value)) return 0;

            int commaPos = value.IndexOf(',');
            if (commaPos == -1)
                return int.Parse(value);

            string num1 = value.Substring(0, commaPos);
            string num2 = value.Substring(commaPos + 1);

            return int.Parse(num1) + int.Parse(num2);
        }
    }
}
