/*
 * What is Breadth First Search (BFS)?
 * Breadth First Search (BFS) is an algorithm used to traverse or search through a graph or tree data structure.
 * It explores all the nodes at the current depth before moving to the next depth level.
 *
 * Example:
 * Given a graph:
 *        A
 *      /   \
 *     B     C
 *    / \      \
 *   D   E      F
 * BFS starting from A would visit nodes in the order: A, B, C, D, E, F.
 *
 * Usage in Games:
 * BFS is particularly useful in various game scenarios:
 *
 * 1. **Shortest Path in Unweighted Graphs**:
 *    - BFS can find the shortest path in an unweighted graph, which is useful for navigation in games.
 *
 * 2. **Flood Fill Algorithm**:
 *    - BFS is used in flood fill algorithms, such as filling a region in a 2D grid (e.g., paint fill or area control in strategy games).
 *
 * 3. **AI Pathfinding**:
 *    - BFS can be used to help NPCs find their way to a target in levels with simple layouts.
 *
 * 4. **Level Traversal**:
 *    - BFS can simulate exploring all options at a particular depth before progressing, like exploring all rooms on one floor of a building.
 *
 * Example Scenario:
 * In a strategy game, BFS can help determine the shortest path from one unit to another across an unweighted terrain.
 * In puzzle games, BFS can be used to solve problems like finding the optimal way to fill an area or connect points.
 */
using System;
using System.Collections.Generic;

public class BreadthFirstSearch
{
    public static void Main(string[] args)
    {
        // Create a graph with 6 nodes
        Graph graph = new Graph(6);

        // Add edges to the graph
        graph.AddEdge(0, 1); // A -> B
        graph.AddEdge(0, 2); // A -> C
        graph.AddEdge(1, 3); // B -> D
        graph.AddEdge(1, 4); // B -> E
        graph.AddEdge(2, 5); // C -> F

        // Perform Breadth First Search starting from node 0 (A)
        Console.WriteLine("Breadth First Search (starting from node A):");
        graph.BreadthFirstSearch(0);
    }
}

public class Graph
{
    private List<int>[] adjacencyList;

    public Graph(int size)
    {
        // Initialize adjacency list for each node
        adjacencyList = new List<int>[size];
        for (int i = 0; i < size; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int src, int dst)
    {
        // Add an edge from src to dst
        adjacencyList[src].Add(dst);
    }

    public void BreadthFirstSearch(int start)
    {
        // Create a queue for BFS
        Queue<int> queue = new Queue<int>();

        // Track visited nodes
        bool[] visited = new bool[adjacencyList.Length];

        // Mark the starting node as visited and enqueue it
        visited[start] = true;
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            // Dequeue a node and print it
            int current = queue.Dequeue();
            Console.WriteLine($"Visited Node: {GetNodeLabel(current)}");

            // Enqueue all adjacent nodes that haven't been visited
            foreach (int neighbor in adjacencyList[current])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
    }

    private string GetNodeLabel(int index)
    {
        // Convert node index to a label (e.g., 0 -> A, 1 -> B, ...)
        return ((char)('A' + index)).ToString();
    }
}
