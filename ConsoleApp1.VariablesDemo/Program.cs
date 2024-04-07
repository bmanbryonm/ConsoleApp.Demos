// See https://aka.ms/new-console-template for more information

// different datatypes
/*
    text - string
    integers - int
    decimal - double, float, decimal (difference is the amount of precision)
    logical - bool 
*/

string name = "Bryon Montgomery";

Console.WriteLine("I am " + name);              // String concatenation
Console.WriteLine($"They call me {name}");      // String interpolation
Console.WriteLine("I was given the name: {0}", name); // Formatted string

int age = 58;
int retirementYearsLeft = 12;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);

Console.ReadKey();


