using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
float MilesToKm(float Miles)
{
    float result = Miles * 1.6f;
    return result;
}

// TODO: A function with no return value has a 'void' type
void PrintWithPrefix(string theStr)
{
    Console.WriteLine($"::> {theStr}");
}

// TODO: Call first function
Console.WriteLine($"The result is {MilesToKm(8.0f)}");
Console.WriteLine($"The result is {MilesToKm(52.0f)}");

// TODO: Call second function
PrintWithPrefix("The string.");
PrintWithPrefix("Another string.");

