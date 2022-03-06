using System;

namespace MethodTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Tasks
            #region Task 1
            //Console.Write("Array-a ölçü verin: ");
            //int arrSize = Convert.ToInt32(Console.ReadLine());
            //int result = Min(arrSize);
            //Print(result);
            #endregion

            #region Task 2
            //Console.Write("Ədəd daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int result = NumLength(num);
            //Print(result);
            #endregion

            #region Task 3
            //string input = Console.ReadLine();
            //int result = VowelLetter(input);
            //Print(result);
            #endregion
            #endregion

            #region Overload Tasks

            #region Task 1
            //int radius = Convert.ToInt32(Console.ReadLine());
            //int result = Area(radius);
            //Print(result);
            #endregion

            #region Task 2
            //int firstSide = Convert.ToInt32(Console.ReadLine());
            //int secondSide = Convert.ToInt32(Console.ReadLine());
            //int result = Area(firstSide, secondSide);
            //Print(result);
            #endregion

            #region Task 3
            //int firstSide = Convert.ToInt32(Console.ReadLine());
            //int secondSide = Convert.ToInt32(Console.ReadLine());
            //int thirdSide = Convert.ToInt32(Console.ReadLine());
            //int result = Area(firstSide, secondSide, thirdSide);
            //Print(result);
            #endregion

            #region Task 4
            //Console.Write("a terefini daxil edin: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b terefini daxil edin: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c terefini daxil edin: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.Write("r-i daxil edin: ");
            //int r = Convert.ToInt32(Console.ReadLine());
            //int result = Area(a, b, c, r);
            //Print(result);
            #endregion

            #region Task 5 symbol
            //Console.WriteLine("Mətn daxil edin:");
            //string text = Console.ReadLine();
            //Console.WriteLine("Axtardığınız simvolu daxil edin:");
            //char symbol = Convert.ToChar(Console.ReadLine());
            //bool result = HasLetter(text, symbol);
            //Console.WriteLine(result);
            #endregion

            #region Task 5 word
            //Console.WriteLine("Mətn daxil edin:");
            //string text = Console.ReadLine();
            //Console.WriteLine("Axtardığınız simvolu daxil edin:");
            //string word = Console.ReadLine();
            //bool result = HasLetter(text, word);
            //Console.WriteLine(result);
            #endregion

            #endregion

        }

        #region Method Tasks
        #region Task 1 və 2-nin Print metodu.
        //static void Print(int result)
        //{
        //    if (result == -1)
        //        Console.WriteLine("Ədəd 0 və ya mənfi ədəd ola bilməz.");
        //    else
        //        Console.WriteLine(result);
        //}
        #endregion

        #region Task 1. Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır.
        //static int Min(int arrSize)
        //{
        //    if (arrSize > 0)
        //    {
        //        int[] arr = new int[arrSize];
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            Console.Write($"{i + 1}. elementi daxil edin: ");
        //            arr[i] = Convert.ToInt32(Console.ReadLine());
        //        }
        //        int minEl = arr[0];
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] < minEl)
        //            {
        //                minEl = arr[i];
        //            }
        //        }
        //        return minEl;
        //    }
        //    return -1;
        //}
        #endregion

        #region Task 2. NumLength methodu yaradılır. Daxil olunan ədədin rəqəmləri sayını tapır.
        //static int NumLength(int num)
        //{
        //    int count = 0, result = 0;
        //    if (num > 0)
        //    {
        //        while (num > 0)
        //        {
        //            result += (num % 10);
        //            num = num / 10;
        //            count++;
        //        }
        //        //foreach (int el in num.ToString()) <-- ToString metodu keçilmədiyi üçün bu hissəni comment-ə atdım -->
        //        //{
        //        //    count++;
        //        //}
        //        return count;
        //    }
        //    return -1;
        //}
        #endregion

        #region Task 3. VowelLetter yaradılır. Daxil olunan mətndə neçə sait hərf olduğunu tapsın
        //static int VowelLetter(string input)
        //{
        //    int count = 0;
        //    foreach (var vowels in input.ToLower())
        //    {
        //        if (vowels == 'a' || vowels == 'e' || vowels == 'i' || vowels == 'o' || vowels == 'u') 
        //            count++;
        //    }
        //    return count;
        //}
        //static void PrintVowelLetter(int result)
        //{
        //    if (result == 0)
        //        Console.WriteLine("Bu text-də sait yoxdur.");
        //    else
        //        Console.WriteLine(result);
        //}
        #endregion
        #endregion

        #region Overload Tasks

        #region Task 1. Çevrənin sahəsi
        static int Area(int radius)
        {
            if (radius > 0)
                return radius * radius * 3;
            else
                return -1;
        }
        #endregion

        #region Task 2. Düzbucaqlının sahəsi
        static int Area(int a, int b)
        {
            if (a > 0 && b > 0)
                return a * b;
            else
                return -1;
        }
        #endregion

        #region Task 3. Düzbucaqlı paralelpipedin tam səthinin sahəsi
        static int Area(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
                return 2 * (a * b + a * c + b * c);
            else
                return -1;
        }
        #endregion

        #region Task 4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi
        static int Area(int a, int b, int c, int r)
        {
            if (a > 0 && b > 0 && c > 0 && r > 0)
            {
                return ((a + b + c) / 2) * r;
            }
            else
                return -1;
        }
        #endregion

        #region Task 5. HasLetter methodu yaradılır. Mətn, daha sonra axtarılan hərf və ya söz yazılır. Əgər axtarılan söz və ya hərf varsa ekranda bu bildirilir.
        //static bool HasLetter(string inputText, char symbol)
        //{
        //    foreach (char text in inputText.ToLower())
        //    {
        //        if (text == symbol)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //static bool HasLetter(string inputText, string word)   <-- Overload tasklarına aid olduğu üçün overload ilə yazdım amma tək bu metod hər iki işi görür həm simvol həm də sözü tapır. -->
        //{
        //    foreach (var text in inputText.ToLower())
        //    {
        //        for (int i = 0; i < word.Length; i++)
        //        {
        //            if (word[i] == text)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}
        #endregion

        #region Print. Sahə Taskları üçün print metodu
        //static void Print(int result)
        //{
        //    if (result == -1)
        //        Console.WriteLine("0 və mənfi ədəd ola bilməz.");
        //    else
        //        Console.WriteLine(result);
        //}
        #endregion

        #endregion

    }
}
