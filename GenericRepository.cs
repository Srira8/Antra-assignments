using System;
using System.Collections.Generic;
using System.Linq;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private readonly List<T> _items = new List<T>();

    public void Add(T item)
    {
        if (item == null) throw new ArgumentNullException(nameof(item));
        _items.Add(item);
    }

    public void Remove(T item)
    {
        if (item == null) throw new ArgumentNullException(nameof(item));
        _items.Remove(item);
    }

    public void Save()
    {
        // Simulating saving to a database
        Console.WriteLine("Changes saved to the data source.");
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    public T GetById(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
    }
}
