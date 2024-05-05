using System;

interface IBasic<T> where T : struct
{
    // Trả về kiểu T
    T Add(T a, T b);
}


class MyFirstClass : IBasic<int>
{
    // Implement phương thức vaff trả về kiểu int
    public int Add(int a, int b) => a + b;
}

// 
class MySecondClass : IBasic<double>
{
    // implement phương thức và trả về kiểu double
    public double Add(double a, double b) => a + b;
}

class Program
{
    static void Main(string[] args)
    {
        
        MyFirstClass firstClass = new MyFirstClass();
        // Gán kết quả vào biến r kiểu dynamic
        dynamic r = firstClass.Add(10, 20);
        Console.WriteLine(r); // In ra kết quả là 30

        MySecondClass secondClass = new MySecondClass();
        // Gán kết quả vào biến r kiểu dynamic
        r = secondClass.Add(10.5, 20.5);
        Console.WriteLine(r); // in ra kết quả

        Console.ReadLine();
    }
}