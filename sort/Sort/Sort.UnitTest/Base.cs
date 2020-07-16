using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.UnitTest
{
    public abstract class Base : ISort<int>
    {
        int[] array = null;
        int[] expectResult = null;

        [SetUp]
        public void Setup()
        {
            array = Generate();

            this.expectResult = JsonConvert.DeserializeObject<int[]>(JsonConvert.SerializeObject(array));
            Array.Sort(this.expectResult);
        }

        private int[] Generate()
        {
            int[] arr = new int[new Random().Next(10, 20)];

            var random = new Random(1000);
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(300);
            }
            return arr;
        }

        public abstract void Sort(int[] array);

        void Print(int[] arr)
        {
            if (arr == null)
            { return; }

            Array.ForEach(arr, x => { Console.WriteLine($"{x},"); });
        }

        public virtual void Test()
        {
            this.Sort(array);

            Print(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(this.array[i], this.expectResult[i]);
            }
        }
    }
}
