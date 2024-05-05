using System;
using System.Collections;

public class IntCollection
{
    private ArrayList arInts = new ArrayList(); // Khai báo một đối tượng ArrayList để lưu trữ các số nguyên

    public int GetInt(int pos) => (int)arInts[pos]; // Phương thức trả về số nguyên tại vị trí pos trong ArrayList

    public void AddInt(int n) => arInts.Add(n); // Phương thức thêm một số nguyên vào ArrayList
    public void ClearInt() => arInts.Clear(); // Phương thức xóa tất cả các số nguyên trong ArrayList
    public int Count => arInts.Count; // Thuộc tính trả về số lượng số nguyên trong ArrayList
}

class Program
{
    static void Main(string[] args)
    {
        int s = 0, number;
        IntCollection collection = new IntCollection(); // Tạo một đối tượng IntCollection

        collection.AddInt(10); // Thêm số nguyên 10 vào IntCollection
        collection.AddInt(20); // Thêm số nguyên 20 vào IntCollection
        collection.AddInt(30); // Thêm số nguyên 30 vào IntCollection

        for (int i = 0; i < collection.Count; i++) // Vòng lặp để duyệt qua từng số nguyên trong IntCollection
        {
            number = collection.GetInt(i); // Lấy số nguyên tại vị trí i trong IntCollection
            s += number; // Cộng số nguyên vào biến s để tính tổng
            Console.Write($" {number}" +
                $"{(i == collection.Count - 1 ? " =" : "+")}"); // In ra số nguyên và dấu "+" hoặc "=" tương ứng

        }
        Console.WriteLine($" {s}"); // In ra tổng của các số nguyên trong IntCollection
    }
}