using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Bubble
{
    /// <summary> 
    /// https://www.cnblogs.com/bigdata-stone/p/10464243.html
    /// </summary>
    public class Bubble : ISort<int>
    {

        public Bubble()
        {

        }
        public void Sort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return;
            }
            var length = array.Length;

            //N个数字冒泡排序，总共要进行N-1趟比较，每趟的排序次数为(N-i)次比较
            for (var i = 0; i < length; i++)
            {
                for (var j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

        }
    }
}

/*
 * https://www.cnblogs.com/bigdata-stone/p/10464243.html
 *(1)由此可见：N个数字要排序完成，总共进行N-1趟排序，每i趟的排序次数为(N-i)次，所以可以用双重循环语句，外层控制循环多少趟，内层控制每一趟的循环次数
 * 冒泡排序总的平均时间复杂度为：O(n的平方)
 */
