using System;

namespace src;

public static class EnumerableExtensions
{
    public static T? FindById<T>(this IEnumerable<T> _items, int id)
      where T : IHasId
    {
        foreach (T item in _items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return default;
    }

    public static IEnumerable<T> Page<T>(this IEnumerable<T> items, int pageNumber, int pageSize)
    {
        if (pageNumber <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(pageNumber), "Page number must be positive.");

        if (pageSize <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(pageSize), "Page size must be positive.");

        int start = (pageNumber - 1) * pageSize;
        int end = start + pageSize;

        int index = 0;

        foreach (T item in items)
        {
            if (index >= start && index < end)
            {
                yield return item;
            }

            if (index >= end)
                yield break;

                index++;
        }
    }
}
