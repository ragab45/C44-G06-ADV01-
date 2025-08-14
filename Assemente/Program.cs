namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {

            #region V-1

namespace SessionDemoAdvanced
    {
        //    public static class Helper
        //    {
        //        // 1 reference
        //        public static void Swap<T>(ref T x, ref T y)
        //        {
        //            T temp = x;
        //            x = y;
        //            y = temp;
        //        }

        //        /*public static void Swap(ref int x, ref int y)
        //        {
        //            int temp = x;
        //            x = y;
        //            y = temp;
        //        }*/
        //    }
        //}
        #endregion
        #region V-2
        public class EvenNumberFilter
        {
            public static List<int> GetEvenNumbers(List<int> numbers)
            {
                List<int> evens = new List<int>();

                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        evens.Add(num);
                    }
                }

                return evens;
            }
            #endregion
            #region V-3
            public static class Helper
            {
                // ... (كود دالة Swap من الصورة السابقة)

                // 1 reference
                public static int LinearSearch<T>(T[] numbers, T value)
                {
                    if (numbers?.Length > 0 && value != null)
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i].Equals(value))
                            {
                                return i; // يرجع مكان العنصر (index) إذا وجده
                            }
                        }
                    }
                    return -1; // يرجع -1 إذا لم يجد العنصر في المصفوفة
                }
            }
            #endregion


        }
    }
}

