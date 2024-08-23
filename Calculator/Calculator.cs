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

            string[] lines = value.Split('\n');

            int total = 0;
            foreach (string line in lines)
            {
                string[] numbers = line.Split(',');
                foreach (string number in numbers)
                {
                    total += int.Parse(number);
                }
            }

            return total;
        }
    }
}
