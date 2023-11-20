import Data.List

-- Define the Graph type
data Graph = Graph { vertices :: Int, adjacencyList :: [[Int]] }

-- Create a new graph with a given number of vertices
newGraph :: Int -> Graph
newGraph v = Graph v (replicate v [])

-- Add an edge to the graph (assuming an undirected graph)
addEdge :: Graph -> Int -> Int -> Graph
addEdge graph v w = Graph (vertices graph)
                          (updateList (adjacencyList graph) v w ++ updateList (adjacencyList graph) w v)
  where
    updateList :: [[Int]] -> Int -> Int -> [[Int]]
    updateList lst idx value = take idx lst ++ [value : (lst !! idx)] ++ drop (idx + 1) lst

-- Print the adjacency list representation of the graph
printGraph :: Graph -> IO ()
printGraph graph = mapM_ printVertex [0..(vertices graph - 1)]
  where
    printVertex :: Int -> IO ()
    printVertex v = putStrLn $ "Adjacency list of vertex " ++ show v ++ ": " ++ intercalate " " (map show (adjacencyList graph !! v))

-- Example Usage
main :: IO ()
main = do
    let graph = addEdge (addEdge (addEdge (addEdge (addEdge (addEdge (newGraph 5) 0 1) 0 4) 1 2) 1 3) 1 4) 2 3) 3 4
    printGraph graph
