using System;

namespace src;

public class Store<T>
  where T : class, IHasId
{
    private readonly Dictionary<int, T> _items = new();

    private IReadOnlyDictionary<int, T> _ItemsView;

    public Store()
    {
        _ItemsView = _items;
    }
    public void Add(int id, T item)
    {
        if (_items.ContainsKey(id))
        {
            throw new InvalidOperationException(
                $"An item with ID {id} already exists.");
        }

        _items.Add(id, item);
    }

    public T? GetById(int id)
    {
        if (_items.TryGetValue(id, out T? item))
        {
            return item;
        }
        else return null;



    }

    public IReadOnlyDictionary<int, T> GetAll()
    {
        return _ItemsView;
    }
    public void Remove(int id)
    {


        if (_items.ContainsKey(id))
        {

            _items.Remove(id);
            Console.WriteLine("Course removed successfully");


        }


        Console.WriteLine("Course not found");
        return;

    }
}
