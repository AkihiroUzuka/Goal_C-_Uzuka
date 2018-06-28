using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;

            Console.WriteLine("確認したい例の番号を入力してください。");
            Console.WriteLine("1: Charsプロパティ");
            Console.WriteLine("2: Lengthプロパティ");
            Console.WriteLine("3: IndexOfメソッド");
            Console.WriteLine("4: Insertメソッド");
            Console.WriteLine("5: Substringメソッド");
            Console.WriteLine("6: Replaceメソッド");
            Console.WriteLine("7: Splitメソッド");
            Console.WriteLine("9: 終了");

            do
            {
                Console.Write("番号＞ ");
                try
                {
                    string s = Console.ReadLine();
                    no = int.Parse(s);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

                switch (no)
                {
                    case 1:
                        Console.WriteLine("● Stringクラス Charsプロパティの例");
                        stringCharsExample();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("● Stringクラス Lengthプロパティの例");
                        stringLengthExample();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("● Stringクラス IndexOfメソッドの例");
                        stringIndexOfExample();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("● Stringクラス Insertメソッドの例");
                        stringInsertExample();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("● Stringクラス Substringメソッドの例");
                        stringSubstringExample();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("● Stringクラス Replaceメソッドの例");
                        stringReplaceExample();
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine("● Stringクラス Splitメソッドの例");
                        stringSplitExample();
                        Console.WriteLine();
                        break;

                }
            } while (no != 9);
        }

        static void stringCharsExample()
        {
            string str = "ABC";
            char c = str[1];
            Console.WriteLine("c = {0}", c);

            string str2 = "Computer";
            for (int i = 0; i < str2.Length; i++)
            {
                Console.Write("[{0}]", str2[i]);
            }
            Console.WriteLine();
        }

        static void stringLengthExample()
        {
            string str = "ABC", str2 = "あいうえお";
            int length1 = str.Length;
            int length2 = str2.Length; 
            Console.WriteLine("{0} : {1} 文字", str, length1);
            Console.WriteLine("{0} : {1} 文字", str2, length2);
        }

        static void stringIndexOfExample()
        {
            string str = "ABC", str2 = "1234567";
            int index1 = str.IndexOf('B');
            int index2 = str2.IndexOf("345");
            Console.WriteLine("index1 = {0}", index1);
            Console.WriteLine("index2 = {0}", index2);
        }

        static void stringInsertExample()
        {
            string str = "ABC";
            string str2 = str.Insert(2, "123");
            Console.WriteLine("str2 = {0}", str2);
        }

        static void stringSubstringExample()
        {
            string str = "1234567";
            string str2 = str.Substring(3);
            string str3 = str.Substring(2, 3);
            Console.WriteLine("str2 = {0}", str2);
            Console.WriteLine("str3 = {0}", str3);
        }

        static void stringReplaceExample()
        {
            string str = "My dog eats dog food.";
            string str2 = str.Replace("dog", "cat");
            Console.WriteLine("{0} ⇒ {1}", str, str2);
        }

        static void stringSplitExample()
        {
            string s1 = "Red,Green,Blue,White";
            string[] w1 = s1.Split(',');        // 区切り文字に「,」を指定して分割
            foreach (string w in w1)
            {
                Console.Write("[{0}] ", w);
            }
            Console.WriteLine();

            char[] delimiter = { '.', ',', ':' };
            string s2 = "red,green.blue,white:yellow";
            string[] w2 = s2.Split(delimiter);  // 区切り文字に「.」と「,」と「:」を指定
            foreach (string w in w2)
            {
                Console.Write("[{0}] ", w);
            }
        }
    }
}
