using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class MyArray<T>
    {
        public T[] arrays = new T[0];
                                                        
        public void Add(T item)
        {
            var tmp = new List<T>(arrays);
            tmp.Add(item);
            arrays = tmp.ToArray();
        }

        public void Remove(T item)
        {
            var tmp = new List<T>(arrays);
            tmp.Remove(item);
            arrays = tmp.ToArray();
        }

        public T GetIndex(int index)
        {
            return arrays[index];
        }

        public int GetLenght()
        {
            return arrays.Length;
        }

        public void PrintInfo()
        {
            foreach (var item in arrays)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
