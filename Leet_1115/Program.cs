public class FooBar
{
    private int n;
    //private SemaphoreSlim foo = new SemaphoreSlim(1);
    private AutoResetEvent foo = new AutoResetEvent(true);
    private AutoResetEvent bar = new AutoResetEvent(false);
    //private SemaphoreSlim bar = new SemaphoreSlim(0);

    public FooBar(int n)
    {
        this.n = n;
    }

    public void Foo(Action printFoo)
    {

        for (int i = 0; i < n; i++)
        {
            foo.WaitOne();
            //foo.Wait();
            // printFoo() outputs "foo". Do not change or remove this line.
            printFoo();
            bar.Set();
            //bar.Release();
        }
    }

    public void Bar(Action printBar)
    {

        for (int i = 0; i < n; i++)
        {
            bar.WaitOne();
            //bar.Wait();
            // printBar() outputs "bar". Do not change or remove this line.
            printBar();
            //foo.Release();
            foo.Set();
        }
    }
}

