# Write a program for Hill Climbing Algorithm.

theBoard = {
    '7': ' ' , '8': ' ' , '9': ' ' , 
    '4': ' ' , '5': ' ' , '6': ' ' ,
    '1': ' ' , '2': ' ' , '3': ' ' 
}

boardKeys=[]

for key in theBoard:
    boardKeys.append(key)
    
def gameOver(turn):
    printBoard()
    print("\nGame Over")
    print(f"{turn} won.")
    
def printBoard():
    print(f"{theBoard['7']} | {theBoard['8']} | {theBoard['9']}")
    print('--+---+--')
    print(f"{theBoard['4']} | {theBoard['5']} | {theBoard['6']}")
    print('--+---+--')
    print(f"{theBoard['1']} | {theBoard['2']} | {theBoard['3']}")

def findWinner():
    if theBoard['7'] == theBoard['8'] == theBoard['9'] != ' ':
        return True
    elif theBoard['4'] == theBoard['5'] == theBoard['6'] != ' ':
        return True
    elif theBoard['1'] == theBoard['2'] == theBoard['3'] != ' ':
        return True
        
    # Vertical
    elif theBoard['7'] == theBoard['4'] == theBoard['1'] != ' ':
        return True
    elif theBoard['8'] == theBoard['5'] == theBoard['2'] != ' ':
        return True
    elif theBoard['9'] == theBoard['6'] == theBoard['3'] != ' ':
        return True
        
    # Diagonal
    elif theBoard['1'] == theBoard['5'] == theBoard['9'] != ' ':
        return True
    elif theBoard['3'] == theBoard['5'] == theBoard['7'] != ' ':
        return True
    
def game():
    turn='X'
    count=0
    
    for i in range(9):
        printBoard()
        move=input(f"Your turn {turn}: ")
        
        if theBoard[move]==' ':
            theBoard[move]=turn
            count+=1
        else:
            print(f"War: The place {move} is already filled. Choose another place")
            continue
            
        if count >= 5:
            if(findWinner):
                gameOver(turn)
                break
              
        if count == 9:
            printBoard()
            print("Game over. Tie!")
        else:
            turn = 'O' if turn == 'X' else 'X'
    restart = input("Play again? (y/n)")
    if restart.lower() == "y":
        for key in boardKeys:
            theBoard[key] = " "       
        game()
    else:
        print("Exit")
        exit

game()