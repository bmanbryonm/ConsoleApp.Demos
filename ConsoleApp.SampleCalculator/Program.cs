// See https://aka.ms/new-console-template for more information

//// Welcome message
//Console.WriteLine("********** - Welcome to the sample calculator! - **********");

//// Prompt for user input
//Console.WriteLine("Please enter the first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter the second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//// Show calculator options

//bool shallExit = false;
//while (!shallExit)
//{
//    Console.WriteLine("********** - Welcome to the sample calculator! - **********");
//    Console.WriteLine("What do you want to do?\n[A]dd\n[S]ubtract\n[M]ultiply\n[D]ivide\n[E]xit");
//    var userInput = Console.ReadLine().ToUpper();

//    switch (userInput)
//    {
//        case "A":
//            Console.WriteLine($"Addition: {num1} + {num2} = " + (num1 + num2));
//            break;
//        case "S":
//            Console.WriteLine($"Subtraction: {num1} - {num2} = " + (num1 - num2));
//            break;
//        case "M":
//            Console.WriteLine($"Multiplication: {num1} x {num2} = " + (num1 * num2));
//            break;
//        case "D":
//            Console.WriteLine($"Division: {num1} / {num2} = " + (num1 / num2));
//            break;
//        case "E":
//            shallExit = true;
//            Console.WriteLine("Exit program");
//            break;
//        default:
//            Console.WriteLine("Invalid entry");
//            break;

//    }
//}

//Console.WriteLine($"The result is: {answer}/n (Press any key to close)");

Console.WriteLine("\n********** - Welcome to the sample calculator! - **********\n\n");

//Show calculator options / show menu
Console.WriteLine("Please select an operation: (-1 to exit the program\n1. Addition\n2. Subraction\n3. Multiplication\n4. Division\n5. Fibonacci sequence\n");
int userChoice = Convert.ToInt32(Console.ReadLine());

while (userChoice != -1)
{
    Console.WriteLine("Please enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int answer = 0;

    switch (userChoice)
    {
        case 1:
            answer = num1 + num2;
            break;
        case 2:
            answer = num1 - num2;
            break;
        case 3:
            answer = num1 * num2;
            break;
        case 4:
            answer = num1 / num2;
            break;
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;

    }

    Console.WriteLine($"The result is: {answer} \n (Press any key to close)");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("\n\nPlease select an operation: (-1 to exit the program)\n1. Addition\n2. Subraction\n3. Multiplication\n4. Division\n5. Fibonacci sequence\n");
    userChoice = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("\n\n********** - Thank you for using the sample calculator! - **********");


Console.ReadKey();


