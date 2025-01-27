/*
 * Adjacency List in Games and Potential Use Cases:
 * 
 * An adjacency list is a data structure used to represent a graph, where each node (or vertex) is connected to a list of its neighbors. 
 * In games, adjacency lists can be used to model various systems such as:
 * 1. **Navigation Meshes**: Representing connections between different points in a 3D or 2D environment for AI pathfinding.
 * 2. **Social Networks**: Modeling relationships between in-game characters or players.
 * 3. **Game Levels**: Representing how different levels or areas in a game are connected.
 * 4. **Dependency Graphs**: Modeling dependencies, such as quests or crafting requirements.
 * 
 * Advantages:
 * - Efficient in terms of space, especially for sparse graphs.
 * - Quick lookups for a node’s neighbors.
 * 
 * Disadvantages:
 * - Slightly slower to search for specific edges compared to adjacency matrices.
 * 
 * Below is an implementation of an adjacency list for a directed graph, with methods to add nodes, add edges, check edge existence, and print the graph.
 */

using System;
using System.Collections.Generic;

public class AdjacencyList
{
    public static void Main(string[] args)
    {
        // Create a new graph
        Graph graph = new Graph();

        // Add nodes (vertices) to the graph
        graph.addNode(new Node('A'));
        graph.addNode(new Node('B'));
        graph.addNode(new Node('C'));
        graph.addNode(new Node('D'));
        graph.addNode(new Node('E'));

        // Add directed edges between nodes
        graph.addEdge(0, 1); // A -> B
        graph.addEdge(0, 2); // A -> C
        graph.addEdge(1, 3); // B -> D
        graph.addEdge(2, 4); // C -> E
        graph.addEdge(3, 4); // D -> E
        graph.addEdge(4, 0); // E -> A
        graph.addEdge(4, 1); // E -> B

        // Print the adjacency list representation of the graph
        graph.printGraph();

        // Check if an edge exists between two nodes
        graph.checkEdge(0, 1);
    }
}

// Represents the Graph using an adjacency list
public class Graph
{
    // A list of linked lists, where each index represents a vertex and contains its neighbors
    private List<LinkedList<Node>> adjacencyList;

    // Constructor to initialize the adjacency list
    public Graph()
    {
        adjacencyList = new List<LinkedList<Node>>();
    }

    // Add a new node to the graph
    public void addNode(Node node)
    {
        // Add an empty linked list for the new node
        adjacencyList.Add(new LinkedList<Node>());
    }

    // Add a directed edge from one node to another
    public void addEdge(int sourceIndex, int destinationIndex)
    {
        // Convert destination index to a Node
        Node destinationNode = new Node((char)('A' + destinationIndex));
        // Add the destination node to the linked list of the source node
        adjacencyList[sourceIndex].AddLast(destinationNode);
    }

    // Check if an edge exists between two nodes
    public void checkEdge(int sourceIndex, int destinationIndex)
    {
        // Convert destination index to a Node
        Node destinationNode = new Node((char)('A' + destinationIndex));
        // Check if the adjacency list of the source contains the destination node
        if (adjacencyList[sourceIndex].Contains(destinationNode))
        {
            Console.WriteLine($"Edge from {(char)('A' + sourceIndex)} to {(char)('A' + destinationIndex)} exists");
        }
        else
        {
            Console.WriteLine($"Edge from {(char)('A' + sourceIndex)} to {(char)('A' + destinationIndex)} does not exist");
        }
    }

    // Print the adjacency list representation of the graph
    public void printGraph()
    {
        int i = 0;
        foreach (LinkedList<Node> list in adjacencyList)
        {
            // Print the vertex
            Console.Write($"Adjacency list of vertex {(char)('A' + i)}: ");
            // Print all neighbors of the vertex
            foreach (Node node in list)
            {
                Console.Write($" -> {node.data}");
            }
            Console.WriteLine(); // Move to the next line
            i++;
        }
    }
}

// Represents a single node (vertex) in the graph
public class Node
{
    // The data stored in the node (e.g., 'A', 'B', etc.)
    public char data;

    // Constructor to initialize the node with data
    public Node(char data)
    {
        this.data = data;
    }

    // Override Equals to compare nodes based on their data
    public override bool Equals(object obj)
    {
        if (obj is Node otherNode)
        {
            return this.data == otherNode.data;
        }
        return false;
    }

    // Override GetHashCode to ensure proper behavior in collections
    public override int GetHashCode()
    {
        return data.GetHashCode();
    }
}
