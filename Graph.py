class Graph:
    def __init__(self, vertices):
        self.vertices = vertices
        self.adjacency_list = {vertex: [] for vertex in range(vertices)}

    def add_edge(self, v, w):
        self.adjacency_list[v].append(w)
        self.adjacency_list[w].append(v)  # Assuming an undirected graph

    def print_graph(self):
        for vertex in range(self.vertices):
            print(f"Adjacency list of vertex {vertex}: {self.adjacency_list[vertex]}")

# Example Usage
if __name__ == "__main__":
    # Create a graph with 5 vertices
    graph = Graph(5)

    # Add edges
    graph.add_edge(0, 1)
    graph.add_edge(0, 4)
    graph.add_edge(1, 2)
    graph.add_edge(1, 3)
    graph.add_edge(1, 4)
    graph.add_edge(2, 3)
    graph.add_edge(3, 4)

    # Print the adjacency list representation of the graph
    graph.print_graph()
