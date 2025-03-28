using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> _items = new List<T>();

    // Returns the count of items in the stack
    public int Count()
    {
        return _items.Count;
    }

    // Adds an item to the stack
    public void Push(T item)
    {
        _items.Add(item);
    }

    // Removes and returns the top item of the stack
    public T Pop()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("Stack is empty");

        T item = _items[_items.Count - 1]; // Get last element
        _items.RemoveAt(_items.Count - 1); // Remove last element
        return item;
    }
}
