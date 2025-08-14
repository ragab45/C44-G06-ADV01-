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
        public class ArrayListReverser
        {
            public static void Reverse(ArrayList list)
            {
                int left = 0;
                int right = list.Count - 1;

                while (left < right)
                {
                    var temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;

                    left++;
                    right--;
                }
            }
            #endregion


        }
    }
}
