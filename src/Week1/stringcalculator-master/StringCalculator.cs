
namespace StringCalculator;

public class StringCalculator
{
    public int Add(string numbers)
    {
        List<char> delimiters = new List<char> { ',', '\n' };
        if (numbers.Contains("//"))
        {
            delimiters.Add(numbers[2]);
            numbers = numbers.Remove(0, 4);
        }
        int sum = 0;
        if (numbers != "")
        {
            char[] delims = delimiters.ToArray();
            string[] nums = numbers.Split(delims);

            List<string> negatives = new List<string>();
            foreach (string num in nums)
            {
                if (num.Contains('-'))
                {
                    negatives.Add(num);
                }
                else
                {
                    int val = int.Parse(num);
                    sum += val;
                }
            }

            if (negatives.Count != 0)
            {
                throw new Exception($"Negatives not allowed: {negatives}");
            }
        }

        return sum;
    }
}

