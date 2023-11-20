using System;
using System.Collections.Generic;

class Graph
{
    private int vertices;
    private List<int>[] adjacencyList;

    public Graph(int vertices)
    {
        this.vertices = vertices;
        adjacencyList = new List<int>[vertices];
        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adjacencyList[v].Add(w);
        adjacencyList[w].Add(v); // Assuming an undirected graph
    }

    public void PrintGraph()
    {
        for (int vertex = 0; vertex < vertices; vertex++)
        {
            Console.Write($"Adjacency list of vertex {vertex}: ");
            foreach (var neighbor in adjacencyList[vertex])
            {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a graph with 5 vertices
        Graph graph = new Graph(5);

        // Add edges
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 4);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);

        // Print the adjacency list representation of the graph
        graph.PrintGraph();
    }
}
