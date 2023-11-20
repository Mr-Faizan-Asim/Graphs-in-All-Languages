#include <iostream>
#include <list>

class Graph {
    int V; // Number of vertices

    // Array of lists to represent adjacency list
    std::list<int>* adj;

public:
    // Constructor
    Graph(int V);

    // Function to add an edge to the graph
    void addEdge(int v, int w);

    // Function to print the adjacency list representation of the graph
    void printGraph();
};

Graph::Graph(int V) {
    this->V = V;
    adj = new std::list<int>[V];
}

void Graph::addEdge(int v, int w) {
    adj[v].push_back(w);
    adj[w].push_back(v); // Assuming an undirected graph
}

void Graph::printGraph() {
    for (int v = 0; v < V; ++v) {
        std::cout << "Adjacency list of vertex " << v << ":\n";
        for (const auto& neighbor : adj[v]) {
            std::cout << " -> " << neighbor;
        }
        std::cout << "\n";
    }
}

int main() {
    // Create a graph with 5 vertices
    Graph g(5);

    // Add edges
    g.addEdge(0, 1);
    g.addEdge(0, 4);
    g.addEdge(1, 2);
    g.addEdge(1, 3);
    g.addEdge(1, 4);
    g.addEdge(2, 3);
    g.addEdge(3, 4);

    // Print the adjacency list representation of the graph
    g.printGraph();

    return 0;
}
