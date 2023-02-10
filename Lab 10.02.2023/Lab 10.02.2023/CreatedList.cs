using System;

namespace Lab_10._02._2023
{


    public class CreatedList<T>
    {
        private T[] arr = new T[0];
        public T this[int i]
        {
            get
            {
                if (i <= arr.Length)
                {
                    Console.WriteLine("EROR");
                }
                return arr[i];
            }
            set
            {
                if (i <= arr.Length)
                {
                    Console.WriteLine("EROR");
                }
            }
        }
        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }
        public void AddItems(params T[] elements)
        {
            foreach (var item in elements)
            {
                Add(item);
            }
        }
        
        public void Clear<T>(ref T[] array)
        {
            Array.Resize(ref array, 0);
        }
        public bool Exsits<T>(T element)
        {
            foreach (var item in arr )
            {
                if (item.Equals(item))
                {
                    return true;
                }
               
            } return false;
        }
        public void IndexofItem(T element)
        {
            foreach (var item in arr)
            {
                if (item.Equals(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
      
    }
}
