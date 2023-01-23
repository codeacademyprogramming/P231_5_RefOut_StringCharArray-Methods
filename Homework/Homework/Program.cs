using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FindFirstNonSpaceIndex("   Hello   World!"));

            Console.WriteLine(RemoveLeftSpace("   Hello,   World!"));

            Console.WriteLine(FindFirst("   Hello    World!"));

            Console.WriteLine(FindWordsCount("Hello,   World"));

            int[] nums = { 4, 34, -23, -4, 5 };


            var newArr = MakePositive(nums);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }

        //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod. Misalçun
        //"  Salam" yazısında S ilk boşluq olmayan char-dır.
        static int FindFirstNonSpaceIndex(string str)
        {
            int index = -1;
            for(var i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    return i;
            }

            return -1;
        }

        //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod

        static int FindWordsCountWithDigit(string[] arr)
        {
            int count = 0;
            for(var i = 0; i < arr.Length; i++)
            {
                //for (int j = 0; i < arr[i].Length; j++)
                //{
                //    if (arr[i][j] >= '0' && arr[i][j] <= '9')
                //    {
                //        count++;
                //        break;
                //    }
                //}
                if (HasDigit(arr[i]))
                    count++;
            }

            return count;
        }

        //Verilmis yazida reqem olub olmamasini tapan metod
        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]>='0' && str[i] <= '9') 
                {
                    return true;
                }
            }

            return false;
        }

        //Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string RemoveLeftSpace(string str)
        {
            string newStr = "";

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] != ' ' || newStr.Length>0)
            //        newStr += str[i];
            //}

            for(int i = FindFirstNonSpaceIndex(str); i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

        //Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)
        static string FindFirst(string str)
        {
            string newStr = "";
            str = RemoveLeftSpace(str);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    newStr += str[i];
                else break;
            }
            return newStr;
        }

        static int FindWordsCount(string str)
        {
            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    count++;
                }
            }
            return count;
        }

        //Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array
        //düzəldən metod. Misalçün verilmiş arraydə {4, -3, 10, -24}  dəyərləridirsə methoddan
        //geriyə {4, 10} dəyərli array qayıdır

        static int[] MakePositive(int[] arr)
        {
            //{ 4, 34, -23, -4, 5 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    count++;
            }

            int j = 0;
            int[] newArr = new int[count];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    newArr[j] = arr[i];
                    j++;
                }
                    
            }

            return newArr;
        }

    }
}
