namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  TASK 1 (ededdeki reqemlerin hasili)

            //while (true) 
            //{
            //    int number = int.Parse(Console.ReadLine());

            //    if (number == 0)
            //        break;
            //    int count = (int)Math.Log10(number);
            //    int reverseNumber = 0;
            //    int r;

            //    while (number !=0) 
            //    {
            //        r = number % 10;
            //        number /= 10;

            //        reverseNumber += r * (int)Math.Pow(10, count);
            //        count--;                

            //    }

            //    int hasil = 1;
            //    while ( reverseNumber != 0)
            //    {
            //        r = reverseNumber % 10;
            //        reverseNumber /= 10;
            //        hasil *= r;
            //        if (reverseNumber != 0)
            //            Console.Write($"{r}*");
            //        else
            //            Console.Write($"{r}={hasil}");
            //    }


            //    Console.WriteLine();


            //}

            #endregion End of TASK 1

            #region TASK 2 (yas meselesi)

            //int n = int.Parse(Console.ReadLine());

            //if ( n >= 1 && n <= 1188) 
            //{
            //    int il = n / 12;
            //    int ay = n - il * 12;

            //    Console.WriteLine($"{n} ay = {il} il ve {ay} ay");

            //}
            //else
            //{
            //    Console.WriteLine("1-1199 intervalinda eded daxil edilmelidir");

            //}
            #endregion End of TASK 2

            #region TASK 3 (sifirlarin sayi)

            //int n = int.Parse(Console.ReadLine());
            //int zeroCount = 0;
            //int tmp = n;

            //while (tmp != 0) 
            //{
            //    if (tmp % 10 == 0) zeroCount++;
            //    tmp /= 10;

            //}

            //Console.WriteLine($"{n}-deki sifirlarin sayi = {zeroCount}");

            #endregion End of TASK 3

            #region TASK 4 (tam ve kesr hisse)

            //decimal n = decimal.Parse(Console.ReadLine());
            //int real = (int)n;
            //decimal kesr = n - real;
            //decimal X = (real / 1000M);
            //decimal reverse = X + kesr * 1000;
            //Console.WriteLine($"{reverse}");

            #endregion End of TASK 4

        }
    }
}