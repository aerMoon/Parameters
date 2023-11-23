namespace ConsoleApp1
{
    internal class Program
    {
        /*
        создать метод, принимающий строку, и возвращающий массив слов*/
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //string[] arrayWords = GetWordsArray(str);
            //foreach (string word in arrayWords) { Console.WriteLine(word); }
            int[] Numbers = { -1, 2, 3, -1, -2, -3 };
            int[] PositiveNumbers = NumbersArray(Numbers); 

            foreach (int n in PositiveNumbers)
            {
                Console.WriteLine(n);
            }
        }
        static string[] GetWordsArray(string s)
        {
            string[] words;
            words = s.Split(' ');
            return words;
        }

        //создать метод принимающий массив чисел,
        //возвращающий массив только с полложительными значениями

        static int[] NumbersArray(int[] array)
        {
            int count = 0;
            foreach (int i in array)
            {
                if (i > 0)
                {
                    count++;
                }

            }
            int[] result = new int[count];
            int b = 0; //отдельный индекс для result
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > 0)
                {
                    result[b] = array[i];
                    b++;
                }
            }
            return result;
        }

    }
}