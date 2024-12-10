

//class FibonacciSeries
//{
//    // Non-recursive method
//    public static void PrintFibonacciNonRecursive(int n)
//    {
//        int first = 0, second = 1, next;

//        Console.WriteLine("Fibonacci Series (Non-Recursive):");
//        if (n >= 1) Console.Write(first + " ");
//        if (n >= 2) Console.Write(second + " ");

//        for (int i = 3; i <= n; i++)
//        {
//            next = first + second;
//            Console.Write(next + " ");
//            first = second;
//            second = next;
//        }
//        Console.WriteLine();
//    }

//    // Recursive helper function to calculate nth Fibonacci number
//    public static int FibonacciRecursive(int n)
//    {
//        if (n == 1) return 0;
//        if (n == 2) return 1;
//        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
//    }

//    // Print Fibonacci series using recursion
//    public static void PrintFibonacciRecursive(int n)
//    {
//        Console.WriteLine("Fibonacci Series (Recursive):");
//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write(FibonacciRecursive(i) + " ");
//        }
//        Console.WriteLine();
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter the number of terms for the Fibonacci series: ");
//        int n = int.Parse(Console.ReadLine());

//        if (n <= 0)
//        {
//            Console.WriteLine("Please enter a positive number greater than 0.");
//            return;
//        }

//        // Non-recursive Fibonacci series
//        PrintFibonacciNonRecursive(n);

//        // Recursive Fibonacci series
//        PrintFibonacciRecursive(n);
//    }
//}


//2.write c# program prime number

//using System;

//class PrimeNumberCheck
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a number to check if it's prime:");
//        int number;
//        if (int.TryParse(Console.ReadLine(), out number) && number > 1)
//        {
//            if (IsPrime(number))
//            {
//                Console.WriteLine($"{number} is a prime number.");
//            }
//            else
//            {
//                Console.WriteLine($"{number} is not a prime number.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Please enter a valid positive integer greater than 1.");
//        }
//    }

//    static bool IsPrime(int number)
//    {
//        if (number <= 1) return false; // Numbers less than 2 are not prime

//        for (int i = 2; i <= Math.Sqrt(number); i++)
//        {
//            if (number % i == 0)
//            {
//                return false; // Number is divisible by another number, so it's not prime
//            }
//        }
//        return true; // Number is prime
//    }
//}

//3.Write a c# program to check palindrome number.


//using System;

//class PalindromeChecker
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter a number: ");
//        string input = Console.ReadLine();

//        // Check if the input is a valid number
//        if (int.TryParse(input, out int number))
//        {
//            if (IsPalindrome(input))
//            {
//                Console.WriteLine($"The number {number} is a palindrome.");
//            }
//            else
//            {
//                Console.WriteLine($"The number {number} is not a palindrome.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//        }
//    }

//    static bool IsPalindrome(string number)
//    {
//        int start = 0;
//        int end = number.Length - 1;

//        while (start < end)
//        {
//            if (number[start] != number[end])
//            {
//                return false;
//            }

//            start++;
//            end--;
//        }

//        return true;
//    }
//}

//4.Write a c# program to print factorial of a number

using System;

class FactorialProgram
{
    static void Main()
    {
        Console.WriteLine("Enter a number to calculate its factorial:");

        // Read and validate user input
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
        {
            Console.WriteLine($"Factorial of {number} is {CalculateFactorial(number)}");
        }
        else
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
        }
    }

    static long CalculateFactorial(int num)
    {
        long factorial = 1;

        // Loop to calculate factorial
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}











