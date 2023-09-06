using CSharpEssentials;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;

namespace CSharpEssentials
{
    public class CustomIterator : IEnumerable, IEnumerable<int>, IEnumerator, IEnumerator<int>, IDisposable
    {
        public object Current => throw new NotImplementedException();

        int IEnumerator<int>.Current => throw new NotImplementedException();

        public void Dispose()
        {
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    static class Where
    {
        static IEnumerable<T> MyWhere<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var iterator = new CustomIterator();

            foreach (var item in iterator)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
