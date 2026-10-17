using System;

public class Store<T> where T : IHasId
{
    public Dictionary<int, T> Items { get; set; }
    public void Add(T item)
    {
        if (this.Items == null)
        {
            this.Items = new Dictionary<int, T>();
        }
        if (Items.ContainsKey(item.Id))
        {
            throw new ArgumentException($"An item with Id {item.Id} already exists.");
        }
        Items[item.Id] = item;
        Console.WriteLine($"Item added: {item}");
    }

    public T? GetById(int id)
    {
        return Items.GetValueOrDefault(id);
    }

    public void Remove(int id)
    {
        if (Items.TryGetValue(id, out T item))
        {
            Items.Remove(id);
            Console.WriteLine($"Item removed: {item}");
        }
    }

    public List<T> GetAll()
    {
        return new List<T>(Items.Values);
    }
}
