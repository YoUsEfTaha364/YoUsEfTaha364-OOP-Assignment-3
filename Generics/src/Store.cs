namespace src;

public class Store<T>
    where T : class, IHasId
{
    private readonly List<T> _items = new();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T? GetById(int id)
    {
        foreach (T item in _items)
        {
            if (item.Id == id) 
            {
                return item;
            }
        }

        return null;
    }

    public List<T> GetAll()
    {
        return _items;
    }
}