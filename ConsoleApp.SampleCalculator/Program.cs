// See https://aka.ms/new-console-template for more information

// Welcome message
Console.WriteLine("********** - Welcome to the sample calculator! - **********");

// Prompt for user input
Console.WriteLine("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculator options

bool shallExit = false;
while(!shallExit)
{
    Console.WriteLine("********** - Welcome to the sample calculator! - **********");
    Console.WriteLine("What do you want to do?\n[A]dd\n[S]ubtract\n[M]ultiply\n[D]ivide\n[E]xit");
    var userInput = Console.ReadLine().ToUpper();

    switch (userInput)
    {
        case "A":
            Console.WriteLine($"Addition: {num1} + {num2} = " + (num1 + num2));
            break;
        case "S":
            Console.WriteLine($"Subtraction: {num1} - {num2} = " + (num1 - num2));
            break;
        case "M":
            Console.WriteLine($"Multiplication: {num1} x {num2} = " + (num1 * num2));
            break;
        case "D":
            Console.WriteLine($"Division: {num1} / {num2} = " + (num1 / num2));
            break;
        case "E":
            shallExit = true;
            Console.WriteLine("Exit program");
            break;
        default:
            Console.WriteLine("Invalid entry");
            break;

    }
}




