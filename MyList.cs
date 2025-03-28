using System;
using System.Collections.Generic;

public class MyList<T>
{
    private List<T> _items = new List<T>();

    // Adds an element to the list
    public void Add(T element)
    {
        _items.Add(element);
    }

    // Removes and returns an element at the specified index
    public T Remove(int index)
    {
        if (index < 0 || index >= _items.Count)
            throw new ArgumentOutOfRangeException("Index out of range");

        T item = _items[index];
        _items.RemoveAt(index);
        return item;
    }

    // Checks if the list contains the given element
    public bool Contains(T element)
    {
        return _items.Contains(element);
    }

    // Clears all elements from the list
    public void Clear()
    {
        _items.Clear();
    }

    // Inserts an element at a specific index
    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _items.Count)
            throw new ArgumentOutOfRangeException("Index out of range");

        _items.Insert(index, element);
    }

    // Deletes an element at a specific index
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= _items.Count)
            throw new ArgumentOutOfRangeException("Index out of range");

        _items.RemoveAt(index);
    }

    // Finds and returns the element at the specified index
    public T Find(int index)
    {
        if (index < 0 || index >= _items.Count)
            throw new ArgumentOutOfRangeException("Index out of range");

        return _items[index];
    }

    // Prints all elements in the list (for debugging)
    public void PrintAll()
    {
        Console.WriteLine("List contents: " + string.Join(", ", _items));
    }
}
