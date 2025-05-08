using System;
using UnityEngine;

public class Starter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 10, y = 20;
        Swap(ref x, ref y);
        Console.WriteLine($"Swapped ints: x = {x}, y = {y}");
        string first = "Hello", second = "World";
        Swap(ref first, ref second);
        Console.WriteLine($"Swapped strings: first = {first}, second = {second}");
        double d1 = 1.5, d2 = 2.5;
        Swap(ref d1, ref d2);
        Console.WriteLine($"Swapped doubles: d1 = {d1}, d2 = {d2}");

    }

    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

}
