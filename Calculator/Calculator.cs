namespace Domain
{
    public class Calculator
    {
        public int Add(string value)
        {
            if (string.IsNullOrEmpty(value)) return 0;

            return int.Parse(value);
        }
    }
}
