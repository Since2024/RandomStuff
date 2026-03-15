Type conversion
using System;
class Program
{
static void Main()
{
// 1. Implicit Conversion
// smaller type -> bigger type automatically
int num = 100;
double bigNum = num;
Console.WriteLine("Implicit Conversion:");
Console.WriteLine("int value = " + num);
Console.WriteLine("converted to double = " + bigNum);
Console.WriteLine();
// 2. Explicit Conversion (Casting)
// bigger type -> smaller type manually
double price = 99.99;
int wholePrice = (int)price;
Console.WriteLine("Explicit Conversion (Casting):");
Console.WriteLine("double value = " + price);
Console.WriteLine("converted to int = " + wholePrice);
Console.WriteLine();
// 3. Method-based Conversion using ToString()
int age = 25;
string ageText = age.ToString();
Console.WriteLine("ToString Conversion:");
Console.WriteLine("int value = " + age);
Console.WriteLine("converted to string = " + ageText);
Console.WriteLine();
// 4. Parse Method
string numberText = "500";
int number = int.Parse(numberText);
Console.WriteLine("Parse Method:");
Console.WriteLine("string value = " + numberText);
Console.WriteLine("converted to int = " + number);
Console.WriteLine();
// 5. TryParse Method
string input1 = "123";
string input2 = "abc";
bool result1 = int.TryParse(input1, out int value1);
bool result2 = int.TryParse(input2, out int value2);
Console.WriteLine("TryParse Method:");
Console.WriteLine("input1 = " + input1);
Console.WriteLine("success = " + result1 + ", value = " + value1);
Console.WriteLine("input2 = " + input2);
Console.WriteLine("success = " + result2 + ", value = " + value2);
Console.WriteLine();
// 6. Convert Class
string marksText = "80";
int marks = Convert.ToInt32(marksText);
double amount = 45.67;
int amountInt = Convert.ToInt32(amount);
Console.WriteLine("Convert Class:");
Console.WriteLine("string to int = " + marks);
Console.WriteLine("double to int = " + amountInt);
Console.WriteLine();
// 7. Char to int
char ch = 'A';
int asciiValue = ch;
Console.WriteLine("Char to Int:");
Console.WriteLine("char value = " + ch);
Console.WriteLine("ASCII value = " + asciiValue);
Console.WriteLine();
// 8. int to char
int letterCode = 66;
char letter = (char)letterCode;
Console.WriteLine("Int to Char:");
Console.WriteLine("int value = " + letterCode);
Console.WriteLine("char value = " + letter);
Console.WriteLine();
// 9. String to double
string salaryText = "12345.50";
double salary = double.Parse(salaryText);
Console.WriteLine("String to Double:");
Console.WriteLine("string value = " + salaryText);
Console.WriteLine("double value = " + salary);
Console.WriteLine();
// 10. Boolean to string
bool isPassed = true;
string passText = isPassed.ToString();
Console.WriteLine("Boolean to String:");
Console.WriteLine("bool value = " + isPassed);
Console.WriteLine("string value = " + passText);
}
}
Value Type and Reference Type
using System;
class Person
{
public string Name;
}
class Program
{
static void Main()
{ // Value type
int a = 10;
int b = a;
b = 20;
Console.WriteLine("Value Type:");
Console.WriteLine("a = " + a); // 10
Console.WriteLine("b = " + b); // 20
Console.WriteLine();
// Reference type
Person p1 = new Person();
p1.Name = "Ram";
Person p2 = p1;
p2.Name = "Shyam";
Console.WriteLine("Reference Type:");
Console.WriteLine("p1.Name = " + p1.Name); // Shyam
Console.WriteLine("p2.Name = " + p2.Name); // Shyam
}
}