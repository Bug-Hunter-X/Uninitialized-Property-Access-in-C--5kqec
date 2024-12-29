public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that is not yet initialized
        int value = MyProperty * 2; 
    }
}