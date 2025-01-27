using System;
using System.Collections.Generic;

public class PriorityQueue
{
    public static void Main(string[] args)
    {
        // Create a priority queue with float elements and int priorities
        var priorityQueue = new PriorityQueue<float, int>();
        
        // Add elements to the priority queue with their associated priorities
        priorityQueue.Enqueue(4f, 4); // Element 4 with priority 4
        priorityQueue.Enqueue(3f, 3); // Element 3 with priority 3
        priorityQueue.Enqueue(2f, 2); // Element 2 with priority 2
        priorityQueue.Enqueue(1f, 1); // Element 1 with priority 1
        
        // Get the number of elements in the priority queue
        int length = priorityQueue.Count;
        
        // Dequeue and print elements from the priority queue
        // Note: PriorityQueue does not have a fixed length, so this loop will run until the queue is empty
        for(int i = 0; i < length; i++)
        {
            // Dequeue the element with the highest priority
            var gpa = priorityQueue.Dequeue();
            
            // Print the dequeued element
            Console.WriteLine(gpa);
        }
    }
}
