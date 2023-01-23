using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 41,22,32, 35,22 };

            var index = Array.LastIndexOf(numbers, 22);

            Array.Sort(numbers);
            Array.Reverse(numbers);
            Array.Clear(numbers, 0, 2);


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            Console.WriteLine(index);

            string str = " Hikmet";

            str = str.ToUpper();
            Console.WriteLine(str);

            Console.WriteLine(str.Contains("MET"));

            str = "  Hello, World";
            var word = str.Substring(0,4);
            Console.WriteLine(word);
            Console.WriteLine(str.IndexOf("l"));
            Console.WriteLine(str.LastIndexOf("l"));
            Console.WriteLine(str.Substring(str.IndexOf(' ')+1));

            //str = str.Replace('l', 'L');
            str = str.Replace("Hello","Goodby");


            str = "Hello,  World!";
            str = str.Trim();

            str.StartsWith("Hello");
            str.EndsWith("ald!");


            Console.WriteLine(str);

            Console.WriteLine(char.IsDigit('a'));
            Console.WriteLine(char.IsDigit('1'));
            Console.WriteLine(char.IsLetterOrDigit('h'));

            Console.WriteLine(char.IsLower('3'));
            Console.WriteLine(char.IsUpper('3'));
            Console.WriteLine(char.ToUpper('a'));



            string sentence = "Salam Hikmet necesen";
            var wordsArr = sentence.Split(" ");

            var newSentence = String.Join(" + ", wordsArr);

            Console.WriteLine(newSentence);




            string name;
            do
            {
                Console.WriteLine("Ad daxil edin:");
                name = Console.ReadLine();

            } while (!char.IsUpper(name[0]));

        }
    }
}
