
 class ListFizzBuzz
{
    public void DisplayFizzBuzz()
    {
        for (int x = 1; x <= 100; x++)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(x);
            }
        }
    }
}