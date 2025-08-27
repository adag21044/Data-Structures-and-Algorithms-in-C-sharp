using System;
using System.Collections.Generic;

public class DictionaryTutorial
{
    public static void Main(string[] args)
    {
        // 1. Creating a Dictionary
        // Dictionary<TKey, TValue> => Key: int, Value: string
        Dictionary<int, string> countryCodes = new Dictionary<int, string>();

        // 2. Adding elements to the Dictionary (Add method)
        countryCodes.Add(1, "United States");
        countryCodes.Add(44, "United Kingdom");
        countryCodes.Add(90, "France");

        // 3. Adding elements to the Dictionary (using indexer)
        countryCodes[49] = "Germany"; // If key 49 does not exist, it will add. If it exists, it will update.

        // 4. Accessing values by key
        Console.WriteLine("Code 1 -> " + countryCodes[1]);

        // 5. Checking if a key exists
        if (countryCodes.ContainsKey(44))
        {
            Console.WriteLine("44 exists: " + countryCodes[44]);
        }

        // 6. Checking if a value exists
        if (countryCodes.ContainsValue("France"))
        {
            Console.WriteLine("France exists in the dictionary.");
        }

        // 7. Safe way to get a value (TryGetValue)
        if (countryCodes.TryGetValue(90, out string country))
        {
            Console.WriteLine("Code 90 -> " + country);
        }

        // 8. Iterating through the Dictionary (foreach loop)
        Console.WriteLine("\n--- All Countries ---");
        foreach (KeyValuePair<int, string> entry in countryCodes)
        {
            Console.WriteLine($"Code: {entry.Key}, Country: {entry.Value}");
        }

        // 9. Removing an element
        countryCodes.Remove(49); // Removes Germany

        // 10. Getting the number of elements in the Dictionary
        Console.WriteLine("\nDictionary count: " + countryCodes.Count);
    }
}
