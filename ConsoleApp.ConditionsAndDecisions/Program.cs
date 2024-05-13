// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Decide to print pass or fail based on input

if ( grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommend student to student affairs office");
}

Console.WriteLine("Thank you for using this program");

// Ternary operator - Used to assign a value to a variable based on a condition

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student Status is: {passStatus}");

if ( grade < 50 )
{
    Console.WriteLine("Student has failed - F");
}
else if ( grade >= 50 && grade <=69 )
{
    Console.WriteLine("Student has passed: D");
}
else if ( grade >= 70 && grade <= 79 )
{
    Console.WriteLine("Student has passed: C");
}
else if (grade >= 80 && grade <= 89)
{
    Console.WriteLine("Student has passed: B");

}
else if (grade >= 90 && grade <= 100)
{
    Console.WriteLine("Student grade is A - good job");
}
int gradeAfterBonus = grade >= 0 && grade <= 100 ? grade + 10 : 0;
Console.WriteLine("Grade after bonus: " + gradeAfterBonus);


Console.WriteLine("Please enter the day of the week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());


switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Today is Sunday");
    break;
    case 2:
        Console.WriteLine("Today is Monday");
    break;
    case 3:
        Console.WriteLine("Today is Tuesday");
    break;
    case 4:
        Console.WriteLine("Today is Wednesday");
        Console.WriteLine("Hump Day!!!");
        break;
    case 5:
        Console.WriteLine("Today is Thursday");
        Console.WriteLine("Almost Friday...");
        break;
    case 6:
        Console.WriteLine("Today is Friday");
        Console.WriteLine("TGIF!!");
        break;
    case 7:
        Console.WriteLine("Today is Saturday");
    break;
    default:
        Console.WriteLine("Invalid input");
    break;
}



Console.ReadKey();
