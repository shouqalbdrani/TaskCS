using System;

using System;

class Program
{
    static void Main()
    {
       // Console.WriteLine("Hello, Shouq! Welcome to C#.");

       // int age = 25;
       // double price = 10.88;
       // string name = "Shouq";
       // bool isStudent = true;

        // Fixed spacing and used string interpolation
       // Console.WriteLine($"My name is {name}, and my age is {age}.");
      // Console.Write("Enter your name: "); // Added space for readability
      //  string username = Console.ReadLine();

       // Console.Write("Enter your age: "); // Added space for readability
       // int userAge = Convert.ToInt32(Console.ReadLine()); // Convert input string to int

        // Corrected string interpolation
       // Console.WriteLine($"Hello {username}, you are {userAge} years old!");


        // Console.Write("Enter the number: "); // Added space for readability
        // int number = Convert.ToInt32(Console.ReadLine());

        // if (number > 0)
        // {
        //     Console.WriteLine("The number is Positive");
        // }
        // else if (number < 0)
        // {
        //     Console.WriteLine("The number is Negative");
        // }
        // else // Removed extra closing bracket `}`
        // {
        //     Console.WriteLine("The number is Zero");
        // }



      // for (int i = 0; i < 5; i++)
       // {
       //     Console.WriteLine( i);
       // }

    //    static int AddNumbers(int a , int b ){
    //     return a+b;
    //    }

    //    int sum = AddNumbers(4,5);

    //    Console.WriteLine("sum is " + sum);

    // Car myCar = new Car();
    //     myCar.Brand = "Lexus"; // Setting brand
    //     myCar.Year = 2025; // Setting year

    //     myCar.Drive();

    // }



//     int count =1;


//     while(count <= 3){
//     Console.WriteLine(count);
//     count++;
//     }
// int[] numbers = new int[5];  // Declaring an array of size 5
//         numbers[0] = 10;  // Assigning values
//         numbers[1] = 20;
//         numbers[2] = 30;
//         numbers[3] = 40;
//         numbers[4] = 50;

//         int[] numbers2 = {10, 20, 30, 40, 50};  // Direct initialization

//         Console.WriteLine(numbers[0]);  // Output: 10

//         // Corrected for-loop with proper braces
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine(numbers[i]);
//         }

//         // foreach loop to print array elements
//         foreach (int num2 in numbers)
//         {
//             Console.WriteLine(num2);
//         }

//         int sum = AddNumbers(4, 9);
//         Console.WriteLine("Sum is " + sum);
//     }

//     // Correctly placed method inside class
//     static int AddNumbers(int a, int b)
//     {
//         return a + b;
//     }

        // try catch (Error Hadling)

       // Console.ReadLine("Enter the number:")

        int[] numbers = {10, 20, 30, 40, 50};
        Console.WriteLine("Original Array: " + string.Join(" ", numbers));

        
        int[] numbers2 = {15, 42, 7, 89, 23};
        int maxNumber = numbers2.Max();
        Console.WriteLine("The maximum number is " + maxNumber);

       
        int[] numbers3 = {1, 2, 3, 4, 5};
        Array.Reverse(numbers3);
        Console.WriteLine("Reversed Array: " + string.Join(" ", numbers3));

        
        int[] numbers4 = {3, 6, 9, 12, 15, 18}; 
        int evenCount = 0;
        int oddCount = 0;

        foreach (int num in numbers4)
        {
            if (num % 2 == 0)
                evenCount++;  // Even number count
            else
                oddCount++;   // Odd number count
        }

        Console.WriteLine("Even numbers: " + evenCount);
        Console.WriteLine("Odd numbers: " + oddCount);

        
        int[] numbers5 = {5, 10, 15, 20}; 
        int sum = 0;

        foreach (int num in numbers5)  
        {
            sum += num;
        }

        Console.WriteLine("Sum of array elements: " + sum);
    }
}



