// Declare variables
//string name = String.Empty;  //clean semantic way to express no value
//int age = 0;
int retirementAge = 65;

// Prompt user for input
Console.WriteLine("Please enter your name: ");
var name = Console.ReadLine();

Console.WriteLine("What is your age: ");
var age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output to user

Console.WriteLine($"Full name: {name}\nAge: {age}\nWorking years remaining: {workingYearsRemaining}");

Console.ReadKey();



