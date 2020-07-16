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
        public void Test1()
        {
            this.Test();
        }
    }
}