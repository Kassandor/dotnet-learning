using System.Collections;

namespace dotnet_learning;

/// <summary>
/// Последовательность
/// </summary>
/// <param name="start">старт</param>
/// <param name="count">конец</param>
public class NumberSeq(int start, int count) : IEnumerable<int>
{
    /// <summary>
    /// Возвращает перечислитель, созданный руками
    /// </summary>
    /// <returns></returns>
    // public IEnumerator<int> GetEnumerator()
    // {
    //     return new NumberEnumerator(start, end);
    // }

    /// <summary>
    /// Возвращает перечислитель, созданный автоматически, компилятор использует state-machine
    /// Такой подход называется "Итератор"
    /// </summary>
    /// <returns></returns>
    public IEnumerator<int> GetEnumerator()
    {
        for (var i = 0; i < count; i++)
        {
            yield return start + i;
        }
    }

    /// <summary>
    /// Доступ к обратной совместимости
    /// </summary>
    /// <returns></returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

/// <summary>
/// Перечислитель
/// </summary>
/// <param name="start">Старт</param>
/// <param name="count">Количество элементов</param>
public class NumberEnumerator(int start, int count) : IEnumerator<int>
{
    private int _currentIndex = -1;

    /// <summary>
    /// Текущий элемент
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public int Current
    {
        get
        {
            if (_currentIndex < 0 || _currentIndex >= count)
            {
                throw new InvalidOperationException("Enumerator is in an invalid state.");
            }

            return start + _currentIndex;
        }
    }

    /// <summary>
    /// Обратная совместимость, реализация Current старого IEnumerator, так же упаковка Current
    /// </summary>
    object IEnumerator.Current => Current;

    /// <summary>
    /// Переход к след элементу
    /// </summary>
    /// <returns></returns>
    public bool MoveNext()
    {
        if (_currentIndex + 1 >= count) return false;
        _currentIndex++;
        return true;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }

    public void Dispose()
    {
    }
}

internal static class InterfaceEnumerableExample
{
    private static readonly IEnumerable<int> Seq1 = new NumberSeq(10, 3);

    public static void ForEach()
    {
        Console.WriteLine(Seq1.GetEnumerator());
        foreach (var item in Seq1)
        {
            Console.WriteLine(item);
        }
    }
}