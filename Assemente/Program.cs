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
        public static class Helper
        {
            // 1 reference
            public static void Swap<T>(ref T x, ref T y)
            {
                T temp = x;
                x = y;
                y = temp;
            }

            /*public static void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }*/
        }
    }
    #endregion


}
    

