using System;

public class Store<T>
{
    public List<T> Items { get; set; }
    public void Add(T item)
    {
        if (this.Items == null)
        {
            this.Items = new List<T>();
        }
        Items.Add(item);
        Console.WriteLine($"Item added: {item}");
    }

    public T? GetById(int id)
    {
        return Items.FirstOrDefault(c => c.Id == id);
    }

    public void Remove(int id)
    {
        var item = Items.FirstOrDefault(c => c.Id == id);
        if (item != null)
        {
            Items.Remove(item);
            Console.WriteLine($"Item removed: {item}");
        }
    }

    public List<T> GetAll()
    {
        return Items;
    }
}
