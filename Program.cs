using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omikuji {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("10連おみくじ");

            for(int i = 0; i <= 10; i++) {
                Console.ReadKey();
                Console.WriteLine("おみくじの結果は{0}です。", omikuji());
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
