# Implementation of A star search Algorithm in A.I.

graph = {
    'S':[('A',1),('G',10)],
    'A':[('C',1),('B',2)],
    'B':[('D',5)],
    'C':[('D',3),('G',4)],
    'D':[('G',2)],
    'G':None
}

def getHeuristic(n):
    hDist = {
        'S':5,
        'A':3,
        'B':4,
        'C':2,
        'D':6,
        'G':0
    }
    return hDist[n]

def getNeighbors(v):
    if v in graph:
        return graph[v]
    else:
        return None

def AStar(startNode, stopNode):
    openSet = set(startNode)
    closedSet = set()
    g = {}
    parents = {}
    g[startNode] = 0
    parents[startNode] = startNode
    while len(openSet) > 0:
        n = None
        for v in openSet:
            if n == None or (g[v] + getHeuristic(v) < g[n] + getHeuristic(n)):
                n = v
        if n == stopNode or graph[n] == None:
            pass
        else:
            for (m, weight) in getNeighbors(n):
                if m not in openSet and m not in closedSet:
                    openSet.add(m)
                    parents[m] = n
                    g[m] = g[n] + weight
                else:
                    if g[m] > g[n] + weight:
                        g[m] = g[n] + weight
                        parents[m] = n
                        if m in closedSet:
                            closedSet.remove(m)
                            openSet.add(m)
        if n == None:
            print("Path does not exist!")
            return None
        
        if n == stopNode:
            path = []
            while parents[n] != n:
                    path.append(n)
                    n = parents[n]
            path.append(startNode)
            path.reverse()
            print("Path found: {}".format(path))
            return path
        openSet.remove(n)
        closedSet.add(n)
    print("Path does not exist!")
    return None
        
AStar('S', 'G')