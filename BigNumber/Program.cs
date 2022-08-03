//算法描述参见 https://makolyte.com/algorithm-explained-sum-two-big-integers-the-hard-way/
// See https://aka.ms/new-console-template for more information
using BigNumber;
using System.Numerics;
using System.Text;

BigInteger a = BigInteger.Parse("18446744073709551615");
BigInteger b = BigInteger.Parse("18446744073709551615");
var sum = MathUtil.Sum("18446744073709551615", "18446744073709551615");
Console.WriteLine(a + b);
Console.WriteLine(sum);


