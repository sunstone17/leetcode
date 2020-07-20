using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Selection
{
    /// <summary>
    /// 首先在未排序序列中找到最小（大）元素，存放到排序序列的起始位置，
    /// 然后，再从剩余未排序元素中继续寻找最小（大）元素，
    /// 然后放到已排序序列的末尾。以此类推，直到所有元素均排序完毕。 
    /// O(n2)的时间复杂度
    /// </summary>
    public class SelectionSort : ISort<int>
    {
        public void Sort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return;
            }

            var len = array.Length;
            var minIndex = 0;
            var temp = 0;

            for (var i = 0; i < len; i++)
            {
                minIndex = i;
                for (var j = i + 1; j < len; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }

        }
    }
}
