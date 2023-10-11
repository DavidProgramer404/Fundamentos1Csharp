class Program
{
    static void Main()
    {
        // Ejercicio 1 con bucle while
        int i = 1;
        while (i <= 255)
        {
            Console.WriteLine(i);
            i++;
        }

        // Ejercicio 2 con bucle while
        i = 1;
        while (i <= 100)
        {
            if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
            {
                Console.WriteLine(i);
            }
            i++;
        }

        // Ejercicio 3 con bucle while
        i = 1;
        while (i <= 100)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}
