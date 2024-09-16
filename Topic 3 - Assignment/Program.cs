// See https://aka.ms/new-console-template for more information
// Carsen
int roomNumber, graduationYear, rectangleWidth;
double price, radius, area, rectangleLength;
string courseName, fullName;

roomNumber = 29;
graduationYear = 2026;
rectangleWidth = 10;
price = 2.99;
radius = 3;
area = ((Math.PI) * radius * radius);
rectangleLength = 20.5;
courseName = "Computer Science";
fullName = "Carsen Greenwood";

Console.WriteLine("This is room #" + roomNumber);
Console.WriteLine("The price is $" + price);
Console.WriteLine("I am learning a bit about " + courseName + "!");
Console.WriteLine();

Console.WriteLine("My name is " + fullName + " and I'll graduate in " + graduationYear + ".");
Console.WriteLine();

Console.WriteLine("The area of a circle with a radius of 3 centimeters is " + Math.Round(area, 1) + " centimeters.");
Console.WriteLine();

Console.WriteLine("The area of a rectangle with a width of " + rectangleWidth + "cm and a length of " + rectangleLength + "cm is " + (rectangleLength * rectangleWidth) + "cm.");
Console.ReadLine();