using System;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        if (pageNumber < 1)
            throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be greater than or equal to 1.");
        if (pageSize < 1)
            throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be greater than or equal to 1.");

        var firstItemIndex = (pageNumber - 1) * pageSize;
        var lastItemIndex = firstItemIndex + pageSize;

        var index = 0;

        foreach (var item in source)
        {
            if (index >= firstItemIndex && index < lastItemIndex)
            {
                yield return item;
            }

            index++;

            if (index >= lastItemIndex)
                yield break;
        }
    }

    public static (T , int Id) FindById<T>(this IEnumerable<T> source, int id) where T : IHasId
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        foreach (var item in source)
        {
            if (item.Id == id)
                return (item, item.Id);
        }
        throw new InvalidOperationException("Item not found.");
    }
    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        var dictionary = new Dictionary<int, T>();
        foreach (var item in source)
        {
            dictionary[item.Id] = item;
        }
        return dictionary;
    }
}
