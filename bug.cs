public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        // Some code here that doesn't modify _value
    }

    public void AnotherMethod()
    {
        DoSomething();
        if(Value == 0) //Always true. Value is never modified 
        {
            Console.WriteLine("Value is zero");
        }
    }
}