class Graph {
    constructor(vertices) {
        this.vertices = vertices;
        this.adjacencyList = new Array(vertices).fill(null).map(() => []);
    }

    addEdge(v, w) {
        this.adjacencyList[v].push(w);
        this.adjacencyList[w].push(v); // Assuming an undirected graph
    }

    printGraph() {
        for (let vertex = 0; vertex < this.vertices; vertex++) {
            console.log(`Adjacency list of vertex ${vertex}: ${this.adjacencyList[vertex]}`);
        }
    }
}

// Example Usage
const graph = new Graph(5);

// Add edges
graph.addEdge(0, 1);
graph.addEdge(0, 4);
graph.addEdge(1, 2);
graph.addEdge(1, 3);
graph.addEdge(1, 4);
graph.addEdge(2, 3);
graph.addEdge(3, 4);

// Print the adjacency list representation of the graph
graph.printGraph();
