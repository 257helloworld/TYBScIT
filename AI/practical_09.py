# Write a program to solve water jug problem.

a = int(input("Enter Jug A Capacity: "))
b = int(input("Enter Jug B Capacity: "))
ai = int(input("Initially water in Jug A: "))
bi = int(input("Initially water in Jub B: "))
af = int(input("Final state of Jug A: "))
bf = int(input("Final state of Jug B: "))

print("\nList of operations you can do!\n\
      1.Fill Jug A Completely\n\
      2.Fill Jug B Completely\n\
      3.Empty Jug A Completely\n\
      4.Empty Jug B Completely\n\
      5.Pour from Jug A till Jug B filled completely or A becomes empty\n\
      6.Pour from Jug B till Jug A filled completely or B becomes empty\n\
      7.Pour all from Jug B to Jug A\n\
      8.Pour all from Jug A to Jug B\n\
      9.Exit")

while(ai != af or bi != bf):
    op = int(input("Enter operation: "))
    if(op == 1):
        ai = a
    elif(op == 2):
        bi = b
    elif(op == 3):
        ai = 0
    elif(op == 4):
        bi = 0
    # Pour from Jug A till Jug B filled completely or A becomes empty
    elif(op == 5):
        if(b - bi > ai):
            bi = ai + bi
            ai = 0
        else:
            ai = ai - (b - bi)
            bi = b
    # Pour from Jug B till Jug A filled completely or B becomes empty
    elif(op == 6):
        if(a - ai > bi):
            ai = ai + bi
            bi = 0
        else:
            bi = bi - (a - ai)
            ai = a
            
    elif(op == 7):
        ai = ai + bi
        bi = 0
    elif(op == 8):
        bi = bi + ai
        ai = 0
    elif(op == 9):
        break
    print(ai, bi)