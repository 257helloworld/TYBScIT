# Write a program to simulate 4/N Queen problem.

def underAttack(i, j):
    # Checking in same row and same column.
    for k in range(0, N):
        if((board[i][k] == 1) or (board[k][j] == 1)):
            return True
        
    # Checking in diagonal position.
    for k in range(0, N):
        for l in range(0, N):
            if((k + l == i + j) or (k - l == i - j)):
                if board[k][l] == 1:
                    return True
    return False

def NQueen(n):
    if n == 0:
        return True
    for i in range(0, N):
        for j in range(0, N):
            if(not(underAttack(i, j)) and board[i][j] != 1):
                board[i][j] = 1

                if(NQueen(n-1) == True):  # Recursion
                    return True
                
                board[i][j] = 0 # Backtrack
    return False

N = int(input("Enter no. of Queens: "))

board = [[0] * N for _ in range(N)]

NQueen(N) # Call to function

# Print board
for i in board:
    print(i)
