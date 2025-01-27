using System;
using System.Collections.Generic;

//Where are queues useful

// 1. Task Queue: Manage tasks (e.g., animations, sound effects) in a specific order.
// 2. Player Turn Order: Manage player turns in a turn-based game.
// 3. AI Action Queue: Queue AI actions to be executed in sequence.
// 4. Event Queuing: Queue and process game events in order.
// 5. Resource Loading: Queue and process resource loading tasks sequentially.


public class Queue
{
    public static void Main(string[] args)
    {
        // Creating a generic Queue of strings
        Queue<string> queue = new Queue<string>();
        
        // Enqueue elements into the Queue
        queue.Enqueue("Karen");
        queue.Enqueue("Steve");
        queue.Enqueue("Chad");
        queue.Enqueue("Harold");
        
        // Peek at the first element without removing it
        Console.WriteLine("First element in the queue: " + queue.Peek());
        
        // Print all elements in the Queue
        Console.WriteLine("Elements in the queue before Dequeue:");
        foreach (var person in queue)
        {
            Console.WriteLine(person);
        }
        
        // Dequeue the first element from the Queue
        queue.Dequeue();
        
        // Print all elements in the Queue after Dequeue
        Console.WriteLine("Elements in the queue after Dequeue:");
        foreach (var person in queue)
        {
            Console.WriteLine(person);
        }
        
        Console.WriteLine("Queue is empty: " + (queue.Count == 0));
        
        Console.WriteLine(queue.Count);
        
        Console.WriteLine(queue.Contains("Steve"));
    }
}
