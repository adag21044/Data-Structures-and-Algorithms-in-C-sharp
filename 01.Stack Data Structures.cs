using System;
using System.Collections.Generic;
using System.Linq;

public class Stack
{
    public static void Main(string[] args)
    {
        // Create a generic Stack of strings
        Stack<string> gameStack = new Stack<string>();

        // Check if the Stack is empty
        Console.WriteLine("Stack is empty: " + (gameStack.Count == 0));

        // Add games to the Stack
        gameStack.Push("GTA V");
        gameStack.Push("RDR 2");
        gameStack.Push("FIFA 21");
        
        // Pop the last added element from the Stack
        string poppedElement = gameStack.Pop();
        Console.WriteLine(poppedElement + " is popped");
        
        // Peek at the top element without removing it
        string peekedElement = gameStack.Peek();
        Console.WriteLine(peekedElement + " is peeked");

        // Print all games currently in the Stack
        Console.WriteLine("Games in stack:");
        foreach (var game in gameStack)
        {
            Console.WriteLine(game);
        }
        
        // Check if the Stack contains any elements using LINQ
        Console.WriteLine("Stack contains elements: " + gameStack.Any());
        
        // Search for a specific game in the Stack
        bool found = Search(gameStack, "RDR 2");
        Console.WriteLine("Element found: " + found);
    }
    
    // Static method to search for a string in the Stack
    public static bool Search(Stack<string> stack, string str)
    {
        // Check if the Stack contains the specified string
        return stack.Contains(str);
    }
}
