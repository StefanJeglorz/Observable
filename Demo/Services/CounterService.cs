namespace Demo;

public class CounterService
{
    public event EventHandler<int> OnCounterChanged;

    private int count = 0;

    public void Increase()
    {
        count++;
        if (OnCounterChanged != null)
        {
            OnCounterChanged(this, count);
        }
    }
}
