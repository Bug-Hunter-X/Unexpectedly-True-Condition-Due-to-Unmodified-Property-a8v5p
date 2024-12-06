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
        _value = 10; // Modify the value
    }

    public void AnotherMethod()
    {
        DoSomething();
        if(Value == 0) 
        {
            Console.WriteLine("Value is zero");
        }
        else
        {
            Console.WriteLine("Value is not zero"); //This will now be executed
        }
    }
}