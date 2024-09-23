using System;

public class Board
{
    //num for every field
    char[,] fieldsForAMove = new char[3, 3] { {'1', '2', '3'},
                                                     {'4', '5', '6'},
                                                     {'7', '8', '9'} };

    void DrawBoard()
    {

        //X and O
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"First  : ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"X");

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"Second : ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"O");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("");
        //board
        Console.WriteLine($"-------------");
        Console.WriteLine($"| {fieldsForAMove[0, 0]} | {fieldsForAMove[0, 1]} | {fieldsForAMove[0, 2]} |");
        Console.WriteLine($"--------------");
        Console.WriteLine($"| {fieldsForAMove[1, 0]} | {fieldsForAMove[1, 1]} | {fieldsForAMove[1, 2]} |");
        Console.WriteLine($"-------------");
        Console.WriteLine($"| {fieldsForAMove[2, 0]} | {fieldsForAMove[2, 1]} | {fieldsForAMove[2, 2]} |");
        Console.WriteLine($"-------------");
        Console.WriteLine("");
    }
}

