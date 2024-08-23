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

            string[] numbers = value.Split(',');
            int total = 0;
            foreach (string number in numbers)
            {
                total += int.Parse(number);
            }

            return total;
        }
    }
}
