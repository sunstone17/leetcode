using NUnit.Framework;

namespace Sort.UnitTest
{
    public class BubbleTest : Base
    {
        public override void Sort(int[] array)
        {
            new Bubble.Bubble().Sort(array);
        }

        [Test]
        public override void Test()
        {
            base.Test();
        }
    }


    public class SelectionTest : Base
    {
        public override void Sort(int[] array)
        {
            new Selection.SelectionSort().Sort(array);
        }

        [Test]
        public override void Test()
        {
            base.Test();
        }
    }

}