using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    public class MathComputeTest
    {
        private MathCompute mc;
        [TestFixtureSetUp]
        public void Init()
        {
            mc = new MathCompute();
        }

        [Test, TestCaseSource("LargestCases")]
        public void TestLargest(int[] arr, int expected)
        {
            Assert.AreEqual(expected, mc.Largest(arr));
        }

        #region 数据部分
        static object[] LargestCases =
        {
            new object[] {new int[]{1,2,3,4},4},
            new object[] {new int[]{-2, -3, -5, -9},-2},
            new object[] {new int[]{1},1},
            new object[] {new int[]{20,20,20,20},20},
            //new object[] {new int[]{},null}
        };
        #endregion
    }
}