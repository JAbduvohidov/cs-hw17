using System;
using System.Linq;

namespace homework17
{
    internal static class Program
    {
        private static void Main()
        {
            const string s1 = "hello";
            var result1 = s1.Select(item =>
            {
                return item switch
                {
                    'a' => '1',
                    'e' => '2',
                    'i' => '3',
                    'o' => '4',
                    'u' => '5',
                    _ => item
                };
            }).ToArray();
            Console.WriteLine(result1);

            const string s2 = "h3 th2r2";
            var result2 = s2.Select(item =>
            {
                return item switch
                {
                    '1' => 'a',
                    '2' => 'e',
                    '3' => 'i',
                    '4' => 'o',
                    '5' => 'u',
                    _ => item
                };
            }).ToArray();
            Console.WriteLine(result2);

            const string s3 = "gdfgdf234dg54gf*23oP42";
            var result31 = Convert.ToDouble(new string(s3.TakeWhile(Math).Where(char.IsDigit).ToArray()));
            var result32 = Convert.ToDouble(new string(s3.SkipWhile(Math).Where(char.IsDigit).ToArray()));
            var sign = s3.First(item => !Math(item));
            var result3 = sign switch
            {
                '/' => result31 / result32,
                '*' => result31 * result32,
                '+' => result31 + result32,
                '-' => result31 - result32,
                _ => throw new ArgumentOutOfRangeException()
            };
            Console.WriteLine(result3);

            const string s4 = "camelCasing";
            s4.Select(item => char.IsUpper(item) ? $" {item}" : Convert.ToString(item)).ToList().ForEach(Console.Write);
        }

        private static bool Math(char item)
        {
            return item switch
            {
                '*' or '/' or '-' or '+' => false,
                _ => true
            };
        }
    }
}