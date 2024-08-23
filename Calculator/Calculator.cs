namespace Domain
{
    public class Calculator
    {
        public int Add(string value)
        {
            if (string.IsNullOrEmpty(value)) return 0;

            string[] lines = value.Split('\n');

            char delim = ',';
            if ((lines[0].Length == 3) && lines[0].StartsWith("//"))
            {
                delim = lines[0][2];
                lines[0] = "0";
            }

            int total = 0;
            foreach (string line in lines)
            {
                string[] numbers = line.Split(delim);
                foreach (string number in numbers)
                {
                    total += int.Parse(number);
                }
            }

            return total;
        }
    }
}
