using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumber
{
    public class MathUtil
    {
        public static string Sum(string a, string b)
        {
            // 结果
            var sum = new StringBuilder();

            // 进位值
            int carry = 0;

            // 给字符串参数补齐前导0
            if (a.Length != b.Length)
            {
                var maxLength = Math.Max(a.Length, b.Length);
                a = a.PadLeft(maxLength, '0');
                b = b.PadLeft(maxLength, '0');
            }

            for (int i = a.Length - 1; i >= 0; i--)
            {
                // 技巧：用 char 相减的办法得到每位字符的数值（与char '0' 相减）
                var digitSum = (a[i] - '0') + (b[i] - '0') + carry;

                // 如果本位和大于9,进位，并将本位值减10
                if (digitSum > 9)
                {
                    carry = 1;
                    digitSum -= 10;
                }
                else
                {
                    carry = 0;
                }

                // 在结果字符串最左侧（高位）插入本位和
                sum.Insert(0, digitSum);
            }
            // 所有位都加完后，检查最高位是否有进位，如果有，要在最高位插入进位值1
            if (carry == 1)
            {
                sum.Insert(0, carry);
            }

            return sum.ToString();
        }
    }
}
