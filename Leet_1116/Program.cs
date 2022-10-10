public class ZeroEvenOdd
{
    private int n;
    private SemaphoreSlim zero = new SemaphoreSlim(1, 1);
    private SemaphoreSlim even = new SemaphoreSlim(0, 1);
    private SemaphoreSlim odd = new SemaphoreSlim(0, 1);

    private AutoResetEvent _event1 = new AutoResetEvent(true);

    private AutoResetEvent _event2 = new AutoResetEvent(false);

    private AutoResetEvent _event3 = new AutoResetEvent(false);

    public ZeroEvenOdd(int n)
    {
        this.n = n;
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Zero(Action<int> printNumber)
    {
        for(int i = 1; i <= n; i++)
        {
            zero.Wait();
            _event1.WaitOne();
            printNumber(0);
            if (i % 2 == 0)
            {
                even.Release();
                _event2.Reset();
            }
            else
            {
                odd.Release();
                _event3.Reset();
            }
        }
    }

    public void Even(Action<int> printNumber)
    {
        for(int i = 2; i <= n; i += 2)
        {
            even.Wait();
            _event2.WaitOne();
            printNumber(i);
            zero.Release();
            _event1.Reset();
        }
    }

    public void Odd(Action<int> printNumber)
    {
        for (int i = 1; i <= n; i += 2)
        {
            odd.Wait();
            _event3.WaitOne();
            printNumber(i);
            zero.Release();
            _event1.Reset();
        }
    }
}