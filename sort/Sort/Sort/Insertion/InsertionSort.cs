﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Insertion
{
    /// <summary>
    /// 它的工作原理是通过构建有序序列，对于未排序数据，在已排序序列中从后向前扫描，找到相应位置并插入。
    /// 
    /// 
    /// 一般来说，插入排序都采用in-place在数组上实现。具体算法描述如下：
    //从第一个元素开始，该元素可以认为已经被排序；
    //取出下一个元素，在已经排序的元素序列中从后向前扫描；
    //如果该元素（已排序）大于新元素，将该元素移到下一位置；
    //重复步骤3，直到找到已排序的元素小于或者等于新元素的位置；
    //将新元素插入到该位置后；
    //重复步骤2 ~5。
    /// </summary>
    public class InsertionSort : ISort<int>
    {
        public void Sort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return;
            }

            var preIndex = 0;
            var current = 0;
            int temp;


            for (var i = 1; i < array.Length; i++)
            {
                preIndex = i - 1;
                current = array[i];
                while (preIndex >= 0 && array[preIndex] > array[current])
                {
                    array[preIndex - 1] = array[preIndex];
                    preIndex--;
                }

                array[current] = array[preIndex];
            }
        }
    }
}
