using System;
using System.Collections.Generic;

public class ListManager
{
    private List<string> items = new List<string>();

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input. Please enter a valid command.");
                continue;
            }

            if (input == "--")
            {
                items.Clear();
                Console.WriteLine("List cleared.");
            }
            else if (input.StartsWith("+ "))
            {
                string itemToAdd = input.Substring(2).Trim();
                if (!string.IsNullOrEmpty(itemToAdd))
                {
                    items.Add(itemToAdd);
                    Console.WriteLine($"Added: {itemToAdd}");
                }
                else
                {
                    Console.WriteLine("Invalid item. Please enter a valid item to add.");
                }
            }
            else if (input.StartsWith("- "))
            {
                string itemToRemove = input.Substring(2).Trim();
                if (items.Remove(itemToRemove))
                {
                    Console.WriteLine($"Removed: {itemToRemove}");
                }
                else
                {
                    Console.WriteLine("Item not found in the list.");
                }
            }
            else
            {
                Console.WriteLine("Invalid command. Use + to add, - to remove, or -- to clear.");
            }

            Console.WriteLine("Current List: " + (items.Count > 0 ? string.Join(", ", items) : "Empty"));
        }
    }
}
