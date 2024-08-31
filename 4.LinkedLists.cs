using System;

public class Node<T>
{
    // The data stored in the node
    public T Data { get; set; }
    // Reference to the next node in the list
    public Node<T> Next { get; set; }

    // Constructor to initialize a new node with data
    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    // Head node of the list
    private Node<T> head;

    // Constructor to initialize an empty linked list
    public LinkedList()
    {
        head = null;
    }

    // Adds a node to the beginning of the list
    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        newNode.Next = head; // Set the new node's next to the current head
        head = newNode;      // Update the head to be the new node
    }

    // Adds a node to the end of the list
    public void AddLast(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (head == null)
        {
            // If the list is empty, set the new node as the head
            head = newNode;
            return;
        }

        // Traverse to the end of the list
        Node<T> current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        // Set the last node's next to the new node
        current.Next = newNode;
    }

    // Prints all nodes in the list
    public void PrintList()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.WriteLine(current.Data); // Print the data of the current node
            current = current.Next;         // Move to the next node
        }
    }

    // Removes the first occurrence of the specified data from the list
    public void Remove(T data)
    {
        if (head == null) return; // If the list is empty, do nothing

        // If the head node contains the data, update the head
        if (head.Data.Equals(data))
        {
            head = head.Next;
            return;
        }

        // Traverse the list to find the node to remove
        Node<T> current = head;
        while (current.Next != null && !current.Next.Data.Equals(data))
        {
            current = current.Next;
        }

        // Remove the node by skipping it in the list
        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    // Finds the first occurrence of the specified data
    public Node<T> Find(T data)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                return current;
            }
            current = current.Next;
        }
        return null; // Return null if the data is not found
    }

    // Counts the number of nodes in the list
    public int Count()
    {
        int count = 0;
        Node<T> current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    // Clears the list by removing all nodes
    public void Clear()
    {
        head = null; // Simply set the head to null
    }
}

class Program
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddFirst(3);
        list.AddFirst(2);
        list.AddFirst(1);

        list.AddLast(4);
        list.AddLast(5);

        Console.WriteLine("Linked List Contents:");
        list.PrintList(); // Print the contents of the list

        Console.WriteLine("Removing 3:");
        list.Remove(3); // Remove the element with value 3
        list.PrintList(); // Print the list after removal

        Console.WriteLine("Finding 2:");
        var node = list.Find(2);
        Console.WriteLine(node != null ? $"Found: {node.Data}" : "Not Found");

        Console.WriteLine($"Number of elements: {list.Count()}"); // Print the number of elements

        Console.WriteLine("Clearing the list:");
        list.Clear(); // Clear the list
        list.PrintList(); // Print the list after clearing
    }
}
