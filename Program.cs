using System;

class Program
{
    static void Main()
    {
        // Creating a stack of integers
        MyStack<int> intStack = new MyStack<int>();
        intStack.Push(10);
        intStack.Push(20);
        Console.WriteLine("Count: " + intStack.Count()); // Output: 2
        Console.WriteLine("Popped: " + intStack.Pop());  // Output: 20
        Console.WriteLine("Count: " + intStack.Count()); // Output: 1

        // Creating a stack of strings
        MyStack<string> stringStack = new MyStack<string>();
        stringStack.Push("Hello");
        stringStack.Push("World");
        Console.WriteLine("Count: " + stringStack.Count()); // Output: 2
        Console.WriteLine("Popped: " + stringStack.Pop());  // Output: World
    }
}
