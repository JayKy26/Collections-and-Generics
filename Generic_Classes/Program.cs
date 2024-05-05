using System;
using System.Collections.Generic;

public class MyClass<T>
{
    //lưu trữ dữ liệu
    private T data;

    //truy cập, gán giá trị dữ liệuu
    public T Value
    {
        get => data;
        set => data = value;
    }

    //in ra giá trị dữ liệu
    public override string ToString() => $"Value:{data}";
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng và gán giá trị
        MyClass<string> name = new MyClass<string>() { Value = "Jack" };
        Console.WriteLine(name); 
        
        MyClass<float> version = new MyClass<float>() { Value = 5.5f };
        Console.WriteLine(version); 

        // Tạo đối tượng ẩn danh dynamic
        dynamic obj = new { Id = 1, Name = "David" };

        MyClass<dynamic> myClass = new MyClass<dynamic> { Value = obj };
        Console.WriteLine(myClass); 

     
        Console.ReadLine();
    }
}