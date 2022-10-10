// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Foo
{

    public Foo()
    {

    }

    private SemaphoreSlim semaphoreSlim1 = new SemaphoreSlim(0, 1);
    private SemaphoreSlim semaphoreSlim2 = new SemaphoreSlim(0, 1);

    public void First(Action printFirst)
    {

        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        semaphoreSlim1.Release();
    }

    public void Second(Action printSecond)
    {
        semaphoreSlim1.Wait();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        semaphoreSlim2.Release();
    }

    public void Third(Action printThird)
    {
        semaphoreSlim2.Wait();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}