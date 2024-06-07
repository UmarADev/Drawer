using System;
using System.Globalization;

Console.WriteLine("Welcome to the Drawer!");
Console.WriteLine("Choose one option to draw:\n1. Triangle\n2. Square\n3. Rhombus");

string userInput = Console.ReadLine();

switch(userInput)
{
    case "1":
        DrawTriangle();
        break;
    case "2": 
        DrawSquare();
        break;
    case "3":
        DrawRhombus();
        break;
}

static void DrawTriangle ()
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 5; j > i; j--)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < (2 * i - 1); j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void DrawSquare ()
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void DrawRhombus()
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 5; j > i; j--)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < (2 * i - 1); j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < 4; k++)
        {
            Console.WriteLine("*");
        }
    }

    
    
}