public class FizzBuzz
{
    private int n;
    private SemaphoreSlim fizz = new SemaphoreSlim(0);
    private SemaphoreSlim buzz = new SemaphoreSlim(0);
    private SemaphoreSlim fizzbuzz = new SemaphoreSlim(0);
    private SemaphoreSlim number = new SemaphoreSlim(1);

    public FizzBuzz(int n)
    {
        this.n = n;
    }

    // printFizz() outputs "fizz".
    public void Fizz(Action printFizz)
    {
        var count = n / 3 - n / 15;
        for (int i = 1; i <= count; i++)
        {
            fizz.Wait();
            printFizz();
            number.Release();
        }
    }

    // printBuzzz() outputs "buzz".
    public void Buzz(Action printBuzz)
    {
        var count = n / 5 - n / 15;
        for (int i = 1; i <= count; i++)
        {
            buzz.Wait();
            printBuzz();
            number.Release();
        }
    }

    // printFizzBuzz() outputs "fizzbuzz".
    public void Fizzbuzz(Action printFizzBuzz)
    {
        var count = n / 15;
        for (int i = 1; i <= count; i++)
        {
            fizzbuzz.Wait();
            printFizzBuzz();
            number.Release();
        }
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Number(Action<int> printNumber)
    {
        for(int i = 1; i < n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                fizzbuzz.Release();

                number.Wait();
            }
            else if (i % 3 == 0)
            {
                fizz.Release();
                number.Wait();
            }
            else if (i % 5 == 0)
            {
                buzz.Release();
                number.Wait();
            }
            else
            {
                printNumber(i);
            }
        }
    }
}