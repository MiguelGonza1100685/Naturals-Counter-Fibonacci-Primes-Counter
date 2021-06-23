using System;

namespace Natural_Counters
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new string('=', 80));
            Func<int> Counter1 = Natural_counter(5);
            for (int i = 0; i < 12; i++)
            {

                Console.WriteLine(Counter1());

            }

            Console.WriteLine(new string('+', 80));
            Func<int> Counter2 = Fibonacci(13);
            for (int i = 0; i < 1; i++)
            {

                Console.WriteLine(Counter2());

            }

            Console.WriteLine(new string('-', 80));
            Func<int> Counter3 = Primos(13);
            for (int i = 1; i < 2; i++)
            {

                Console.WriteLine(Counter3());

            }



        }

        private static Func<int> Primos(int prm)
        {

            int n = 2, div = 1;

            Func<int> p = () =>
            {
                while (n <= 5)
                {

                    for (int i = 1; i <= prm; i++)
                    {
                        if (n % i == 0)
                        {

                            div++;

                        }
                        if (div>2)
                        {
                            break;
                        }


                    }
                    if (div == 2)
                    {

                        Console.WriteLine("{0} Primo ",n );

                    }
                    div = 0;
                    n++;

                }
                return n;
            };
            return p;







        }

        private static Func<int> Fibonacci(int len)
        {

            int a = 0, b = 1, c = 0;
         

            Func<int> p = () =>
            {

                for (int i = 2; i < len; i++)
                {

                    c = a + b;
                    Console.WriteLine("{0}", c);
                    a = b;
                    b = c;

                }
                return c;

            };
            return p;



        }

        private static Func<int> Natural_counter(int bats)
        {

            int i = 0;

            Func<int> p = () =>
            {
                i = i + 1;

                if (i == bats + 2)
                {
                    i = 1;

                }
                return i;


            };
            return p;


        }
    }
}
