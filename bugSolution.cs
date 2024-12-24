public class MyClass
{
    public int MyProperty { get; set; } = 0; // Solution: Initialize property with a default value

    public void MyMethod()
    {
        // Check if the property is null before accessing it
        Console.WriteLine(MyProperty.ToString()); 
    }

    public void MyMethod2(){
        if(MyProperty != null){
            Console.WriteLine(MyProperty.ToString());
        }else{
            Console.WriteLine("MyProperty is null");
        }
    }
} 