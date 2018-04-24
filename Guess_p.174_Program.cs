using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_p._174
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 64;
            int guess;
            int count = 0;
            int min = 0, max = 100;

            do
            {
                do
                {
                    Console.Write("{0}から{1}までの数値を当ててください。＞", min, max);
                    if (int.TryParse(Console.ReadLine(), out guess) == true && guess <= 100 && guess >= 0)
                    {
                        count++;
                        break;
                    }
                    Console.WriteLine("不正な値です。入力をやり直してください。");
                    continue;
                } while (true);

                if(guess > answer)
                {
                    Console.Write("答えはもっと小さいです。");
                    max = guess;
                    continue;
                }else if(guess < answer)
                {
                    Console.Write("答えはもっと大きいさいです。");
                    min = guess;
                    continue;
                }

                Console.WriteLine("おめでとう、{0}回目で当たりました。", count);
                break;

            } while (true);

            Console.Write("終了するには何かキーを押してください。");
            Console.Read();

        }
    }
}
