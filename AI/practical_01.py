graph = {
    'A': ['B', 'C'],
    'B': ['A', 'D', 'E', 'F'],
    'C': ['A', 'G', 'H'],
    'D': ['B'],
    'E': ['B'],
    'F': ['B'],
    'G': ['C'],
    'H': ['C'],
}

visited = []
queue = []

def bfs(graph, node):
    visited.append(node)
    queue.append(node)
    while queue:
        m = queue.pop(0)
        print(m)

        for neighbour in graph[m]:
            if neighbour not in visited:
                visited.append(neighbour)
                queue.append(neighbour)

print("Breadth First Search: ")
bfs(graph, 'A')