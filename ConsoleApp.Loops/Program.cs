// See https://aka.ms/new-console-template for more information

//10
//Console.WriteLine("*****************Simple For Loop*****************");
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Hello World! - {i + 1}");
//}

//Console.WriteLine("How many times do you want to print Hello World?");
//int userInput = Convert.ToInt32(Console.ReadLine());

//for (int i= 0; i < userInput; i++)
//{
//    Console.WriteLine($"Hello World! {i + 1}");
//}

//While Loop
Console.WriteLine("*****************Simple While Loop*****************");

//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine($"Hello World! - {counter}");
//    counter++;
//}

//int sum = 0;
//int num = 0;
//Console.WriteLine("Please enter the numbers you want summed. (enter -1 to exit the program):");

//while (num != -1)
//{
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num != -1)
//    {
//        sum += num;
//    }
//}

//Console.WriteLine($"The sum of your numbers is {sum}");

//Console.WriteLine("*****************While Loop completed*****************");

//Do While Loop
Console.WriteLine("*****************Do While Loop*****************");

int sum = 0;
int num = 0;

do
{
    Console.WriteLine("Enter the numbers you want summed.  Enter -1 to exit:");
    num = Convert.ToInt32(Console.ReadLine());

    if (num != -1)
    {
        sum += num;
    }

} while (num != -1);

Console.WriteLine($"The sum of your numbers is: {sum}");

Console.WriteLine("*****************Do While Loop completed*****************");




Console.ReadKey();








Console.ReadKey();
