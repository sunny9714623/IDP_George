public class H2O
{
    private SemaphoreSlim _h = new SemaphoreSlim(0, 2);
    private SemaphoreSlim _O = new SemaphoreSlim(1, 1);
    public H2O()
    {

    }

    public void Hydrogen(Action releaseHydrogen)
    {
        _h.Wait();
        // releaseHydrogen() outputs "H". Do not change or remove this line.
        releaseHydrogen();
        if(_h.CurrentCount == 0)
            _O.Release();
    }

    public void Oxygen(Action releaseOxygen)
    {
        _O.Wait();
        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();
        _h.Release(2);
    }
}
