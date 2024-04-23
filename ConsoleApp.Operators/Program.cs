// See https://aka.ms/new-console-template for more information

int num1 = 0;
Console.WriteLine("Please enter the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please enter the second number: ");
var num2 = Convert.ToInt32(Console.ReadLine());

/* Math Operations */

var sum = num1 + num2;  //addition
var product =  num1 * num2; //nultiplication
var quotient = num1 / num2; //division
var difference = num1 - num2;  //subtraction
var mod = num1 % num2;   //modulus

Console.WriteLine("\n****************Math Results****************\n");

Console.WriteLine($"Sum: {sum}" );
Console.WriteLine($"Difference: {difference}" );
Console.WriteLine($"Product: {product}" );
Console.WriteLine($"Quotient: {quotient}" );
Console.WriteLine($"Modulus: {mod}" );

Console.WriteLine("\n****************End Math Results****************\n");


/* Logic Operations & Operators */

var isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine("\n****************Logic Operator Results****************\n");

Console.WriteLine($"Is num1 Greater than num2: {isGreaterThan}");
Console.WriteLine($"Is num1 Less than num2: {isLessThan}");
Console.WriteLine($"Is num1 Equal To num2: {isEqualTo}");
Console.WriteLine($"Is num1 Greater Than or Equal To num2: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is num1 Less Than or Equal To num2: {isLessThanOrEqualTo}");
Console.WriteLine($"Is num1 NOT Equal to num2: {isNotEqualTo}");

Console.WriteLine("\n****************End Logic Operator Results****************\n");

/* Assignment Operators */

Console.WriteLine("\n****************Assignment Operator Results****************\n");

Console.WriteLine($"value of the num1 value is: {num1}");
num1 += 5;
Console.WriteLine($"num1 increased by 5: {num1}");
num1 -= 3;
Console.WriteLine($"num1 subtract by 3: {num1}");
num1 /= 2;
Console.WriteLine($"num1 divided by 2: {num1}");
num1 %= 2;
Console.WriteLine($"num1 modulus 2: {num1}");
num1 *= 10;
Console.WriteLine($"num1 multiplied by 10: {num1}");

Console.WriteLine("\n****************End Assignment Operator Results****************\n");


Console.ReadKey();

