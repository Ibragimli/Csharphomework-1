using System;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verilmis array-deki reqemlerinin cemi 10-dan kicik olan ededlerin sayini tapan alqoritm
            int[] numbers = { 94, 12, 43, 26, 86, 90, 32, 64, 16, 44, 63, 83, 79, 23, };
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int digit;
                var num = numbers[i];
                var sum = 0;
                while (num > 0)
                {
                    digit = num % 10;
                    sum += digit;
                    num = (num - digit) / 10;


                }
                if (sum < 10)
                {

                    counter++;

                }
            }
            if (counter > 0)
            {

                Console.WriteLine("Reqemlerinin cemi 10-dan kicik olan ededlerin sayi - " + counter);



            }
            else
                Console.WriteLine("arrayda reqemlerinin cemi 10-dan kicik olan eded yoxdur");



            // 1-den 8000-dek ededler icerisinde cut olanlarin sayini tapan proqram
            int counters = 0;

            for (int j = 1; j < 8000; j++)
            {
                if (j % 2 == 0)
                {

                    counters++;

                }
            }
            if (counters > 0)
            {

                Console.WriteLine("1-den 8000-dek ededler icerisinde cut olanlarin sayi - " + counters);

            }
            else Console.WriteLine("2-e bolunen yoxdu");




            //Verilmis ededin en yaxin asagi kokalti deyerini tapan alqoritm (kecen ders etdiyimize uygun, misalcun eded 20-dirse 4 qaytarmalidi)


            int N = 21;

            var result = 0;

            for (int b = 0; b * b <= N; b++)
            {
                if (b * b <= N)
                {
                    result = b;

                }

            }
            Console.WriteLine("Verilmis ededin en yaxin asagi kokalti deyeri - " + result);



        }

    }
}
