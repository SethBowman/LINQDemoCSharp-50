using System.Linq;
using LINQDemoCSharp_50;

Console.WriteLine("int collections:");

var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Filtering with LINQ
var numbersAboveFive = numbers.Where(number => number > 5).ToList();

//numbersAboveFive.ForEach(number => Console.WriteLine(number));

//Filter
var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

evenNumbers.ForEach(x => Console.WriteLine(x));

Console.WriteLine();

//Sum method
Console.WriteLine($"Sum: {numbers.Sum()}");

//Average method
Console.WriteLine($"Average: {numbers.Average()}");

//Min and Max methods
Console.WriteLine($"Min: {numbers.Min()}\nMax: {numbers.Max()}");

Console.WriteLine();

//Transforming with LINQ
var squaredNumbers = numbers.Select(number => number * number).ToList();

squaredNumbers.ForEach(x => Console.WriteLine(x));

Console.WriteLine();

Console.WriteLine("string collections");
var names = new string[] { "Douglas", "Filip", "Isaac", "Jason", "Julian", "Mariah", "Muhammad", "Raynard", "Robert", "Samuel", "Seth"};

//Filtering with LINQ
var longerNames = names.Where(name => name.Length > 4).ToArray();

foreach (var name in longerNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();

//Transforming with LINQ
var upperCaseNames = names.Select(name => name.ToUpper()).ToArray();

foreach (var name in upperCaseNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();

//Sorting with LINQ (ordering)

var orderedNames = names.OrderByDescending(x => x.Length).ToArray();

foreach (var name in orderedNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();

var dogOne = new Dog()
{
    Name = "Bingo",
    Age = 5
};

var dogTwo = new Dog()
{
    Name = "Spot",
    Age = 1
};

var dogThree = new Dog()
{
    Name = "Spot",
    Age = 3
};

var dogPark = new List<Dog>() { dogOne, dogTwo, dogThree };

var orderedDogs = dogPark.OrderBy(dog => dog.Name).ThenBy(dog => dog.Age);

foreach (var dog in orderedDogs)
{
    Console.WriteLine($"Name: {dog.Name} | Age: {dog.Age}");
}


