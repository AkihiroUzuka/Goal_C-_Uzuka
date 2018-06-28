using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            const int answer = 32;
            int low = 0, high = 100;
            int n, count = 1;

            do
            {
                while (true)
                {
                    try
                    {
                        Console.Write("{0}から{1}の間の数値を当ててください。＞ ", low, high);
                        n = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto END;
                    }
                    if (n >= low && n <= high)
                        break;
                    else
                        Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
                if (n != answer)
                {
                    count++;
                    if (n < answer)
                    {
                        Console.WriteLine("答はもっと大きいです。\n");
                        low = n + 1;
                    }
                    else
                    {
                        Console.WriteLine("答はもっと小さいです。\n");
                        high = n - 1;
                    }
                }
            } while (n != answer);
            Console.WriteLine("おめでとう。{0}回目で当たりました。", count);

        END:
            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
