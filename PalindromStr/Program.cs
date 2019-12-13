using System;
using System.Linq;

namespace PalindromStr {
    class Program {
        static void Main() {
            string sStr = Console.ReadLine();
            // Реверсирование строки
            string reverseStr = new string(sStr.ToCharArray().Reverse().ToArray());
            // Проверяет строку на равенство
            if (reverseStr.Equals(sStr)) {
                Console.WriteLine("Строка является палиндромом");
            }
            else {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
