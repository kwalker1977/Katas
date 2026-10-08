
public class Calculator
{
    public int Add(string numbers)
    {
        int result;

        if (numbers == "")
        {
          result = 0;
		} else
        {
            result = int.Parse(numbers);
        }

            return result;
    }
}
