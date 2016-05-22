using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omikuji {
    class Program {



        static void Main(string[] args) {
            string[] results = new string[] {
                    "大吉",
                    "中吉",
                    "小吉",
                    "凶",
                    "大凶" };
            Random r = new Random();
            int choice;

            do {
                Console.WriteLine("どちらの方法で実行するか指定してください。");
                Console.WriteLine("変数:0");
                Console.WriteLine("三項演算子:1");
               choice = int.Parse(Console.ReadLine());
            } while(choice >= 1 && choice < 0);

            Console.WriteLine("10連おみくじ");
            for(int i = 0; i <= 10; i++) {
                Console.ReadKey();
                if(choice == 0) Console.WriteLine("おみくじの結果は{0}です。",results[r.Next(5)]);
                else Console.WriteLine("おみくじの結果は{0}です。",omikuji());
            }
            Console.WriteLine("終了");
            Console.ReadKey();
        }

        public static string omikuji() {
            Random rand = new Random();
            return rand.Next(5) == 4 ? "大吉" :
                   rand.Next(5) == 3 ? "中吉" :
                   rand.Next(5) == 2 ? "小吉" :
                   rand.Next(5) == 1 ? "凶" :
                                       "大凶";
        }
    }
}
