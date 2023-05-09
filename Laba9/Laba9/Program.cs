using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите латинский символ: ");
        char latinChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (latinChar >= 'A' && latinChar <= 'Z')
        {
            char cyrillicChar = (char)(latinChar - 'A' + 'А');
            Console.WriteLine($"Похожий кириллический символ: {cyrillicChar} ({(int)latinChar}) [{(int)cyrillicChar}]");
        }
        else if (latinChar >= 'a' && latinChar <= 'z')
        {
            char cyrillicChar = (char)(latinChar - 'a' + 'а');
            Console.WriteLine($"Похожий кириллический символ: {cyrillicChar} ({(int)latinChar}) [{(int)cyrillicChar}]");
        }
        else
        {
            Console.WriteLine("Введенный символ не является латинским.");
        }

        Console.ReadKey();
    }
}