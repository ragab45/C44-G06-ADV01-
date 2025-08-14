using System.Collections;

namespace Demo
{
    internal class Program
    {

        #region Q-1
        //    public class Range<T> where T : IComparable<T>
        //{
        //    public T Min { get; }
        //    public T Max { get; }

        //    public Range(T min, T max)
        //    {
        //        if (min.CompareTo(max) > 0)
        //            throw new ArgumentException("Minimum value cannot be greater than maximum value.");

        //        Min = min;
        //        Max = max;
        //    }

        //    public bool IsInRange(T value)
        //    {
        //        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        //    }

        //    public dynamic Length()
        //    {
        //        return (dynamic)Max - (dynamic)Min;
        //    }
        #endregion
        #region Q-2
        //public class ArrayListReverser
        //{
        //    public static void Reverse(ArrayList list)
        //    {
        //        int left = 0;
        //        int right = list.Count - 1;

        //        while (left < right)
        //        {
        //            var temp = list[left];
        //            list[left] = list[right];
        //            list[right] = temp;

        //            left++;
        //            right--;
        //        }
        //    }
        #endregion
        #region Q-3
        //public class EvenNumberFilter
        //{
        //    public static List<int> GetEvenNumbers(List<int> numbers)
        //    {
        //        List<int> evens = new List<int>();

        //        foreach (var num in numbers)
        //        {
        //            if (num % 2 == 0)
        //            {
        //                evens.Add(num);
        //            }
        //        }

        //        return evens;
        //    }
        #endregion
        #region Q-4
        using System.Collections.Generic;

public class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= items.Length)
                throw new InvalidOperationException("List is full. Cannot add more elements.");

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Invalid index.");

            return items[index];
        }
        #endregion


    }
        }
    


