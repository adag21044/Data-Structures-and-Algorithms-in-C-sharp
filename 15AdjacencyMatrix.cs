/* 
 * What is an Adjacency Matrix?
 * An adjacency matrix is a 2D array used to represent a graph. The rows and columns represent nodes, 
 * and the value at matrix[i][j] indicates whether there is an edge between node i and node j.
 *  - A value of 1 indicates the presence of an edge.
 *  - A value of 0 indicates no edge.
 *
 * Example:
 * If matrix[0][1] = 1, it means there is an edge from node 0 to node 1.
 *
 * Advantages:
 *  - Efficient for dense graphs, where many edges exist.
 *  - Easy to implement and use for basic graph operations.
 *
 * Disadvantages:
 *  - Requires O(V^2) space, where V is the number of vertices (nodes).
 *  - Inefficient for sparse graphs with few edges.
 *
 * Usage in Games:
 * Adjacency matrices can be used to model various scenarios in games:
 * 1. Pathfinding:
 *    - Represent a game map as a graph where nodes are locations and edges represent valid moves.
 *    - Use algorithms like Dijkstra's or A* to find the shortest path between nodes.
 *
 * 2. AI Navigation:
 *    - NPCs can use the adjacency matrix to navigate a level by checking valid moves between locations.
 *
 * 3. Level Design:
 *    - Represent connections between different rooms or areas in a game (e.g., dungeons, portals).
 *
 * 4. Puzzle Design:
 *    - Create puzzles where players need to form or remove connections between nodes to progress.
 * 
 * Example Scenario:
 * In a stealth game, the nodes could represent rooms, and edges could represent pathways or doors.
 * An adjacency matrix could be used to determine whether the player can access a specific room 
 * or if a guard's line of sight overlaps with a pathway.
 */
using System;

public class AdjacencyMatrix
{
    public static void Main(string[] args)
    {
        Graph graph = new Graph(5);

        graph.AddNode(new Node('A'));
        graph.AddNode(new Node('B'));
        graph.AddNode(new Node('C'));
        graph.AddNode(new Node('D'));
        graph.AddNode(new Node('E'));

        // Adding edges between nodes
        graph.AddEdge(0, 1); // A -> B
        graph.AddEdge(1, 2); // B -> C
        graph.AddEdge(2, 3); // C -> D
        graph.AddEdge(2, 4); // C -> E
        graph.AddEdge(4, 0); // E -> A
        graph.AddEdge(4, 2); // E -> C

        graph.Print();

        Console.WriteLine(graph.CheckEdge(0, 1)); // True
    }
}

public class Graph
{   
    // List of nodes in the graph
    List<Node> nodes;

    // Adjacency matrix to represent edges between nodes
    public int[][] matrix;

    public Graph(int size)
    {
        nodes = new List<Node>();

        // Create a 2D array
        matrix = new int[size][];
        for (int i = 0; i < size; i++)
        {
            matrix[i] = new int[size];
        }
    }

    public void AddNode(Node node)
    {
        // Add node to the graph
        nodes.Add(node);
    }

    public void AddEdge(int src, int dst)
    {
        // Add an edge between two nodes in the adjacency matrix
        matrix[src][dst] = 1;
    }

    public bool CheckEdge(int src, int dst)
    {
        // Check if edge exists
        return matrix[src][dst] == 1;
    }

    public void Print()
    {
        Console.Write("  ");
        foreach (Node node in nodes)
        {
            Console.Write(node.data + "  ");
        }
        Console.WriteLine();

        for(int i = 0; i < matrix.Length; i++)
        {
            Console.Write(nodes[i].data + " ");
            for(int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + "  ");
            }
            Console.WriteLine();
        }
    }
}

public class Node
{
    // Data stored in the node
    public char data;

    public Node(char data)
    {
        this.data = data;
    }
}
