using System;

namespace NUnitTest
{
    public class MathCompute
    {
        public int Largest(int[] array)
        {
            if (null == array || 0 == array.Length)
            {
                throw new Exception("参数传递错误");
            }
            int largest = Int32.MinValue;

            foreach (int element in array)
            {
                if (element > largest)
                {
                    largest = element;
                }
            }

            return largest;
        }
    }
}