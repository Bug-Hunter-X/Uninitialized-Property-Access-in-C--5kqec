public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public void MyMethod()
    {
        // MyProperty is now initialized 
        int value = MyProperty * 2; 
    }

    public void MyMethod2()
    {
        MyProperty = 10; // Assigning the value before using it.
        int value = MyProperty * 2;
    }
} 