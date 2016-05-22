using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omikuji {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("10連おみくじ");
            System.Random rnd = new Random();
            
            string[] ary = new string[] { "大吉", "中吉", "小吉", "凶", "大凶" };
            for(int count = 0; count <= 10; count++) {
                Console.WriteLine("おみくじの結果は{0}です。", ary[rnd.Next(0, 4)]);
            }

            Console.WriteLine("終了");
            
        }
    }
}