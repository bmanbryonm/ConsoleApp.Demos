// Declare variables
//string name = String.Empty;  //clean semantic way to express no value
//int age = 0;

int retirementAge = 65;

// Prompt user for input
Console.WriteLine("Please enter your first name: ");
var firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name: ");
var lastName = Console.ReadLine();

Console.WriteLine("What is your age: ");
var age = Convert.ToInt32(Console.ReadLine());

//decimal salary = 0;
//char gender = char.MinValue;
//bool working = false;

Console.WriteLine("Please enter you salary: ");
var salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("What is your gender (M or F): ");
var gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you working? (true or false): ");
var working = Convert.ToBoolean(Console.ReadLine());



// Process the data
int workingYearsRemaining = retirementAge - age;

// Output to user

Console.WriteLine($"Full name: {firstName} {lastName}\nAge: {age}\nNumber of working years remaining: {workingYearsRemaining}\n" +
    $"salary: {salary}\nGender: {gender}\nWorking: {working}");

Console.ReadKey();



