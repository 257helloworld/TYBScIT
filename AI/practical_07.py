# #Write a program to solve tower of Hanoi problem

def toh(disks, source, auxiliary, target):
    if(disks==1):
        print(f"Move disk 1 from rod {source} to rod {target}.")
        return
    toh(disks-1, source, target, auxiliary)
    print(f"Move disk {disks} from rod {source} to rod {target}.")
    toh(disks-1, auxiliary, source, target)
disks = int(input("Enter number of disks: "))
toh(disks, 'A', 'B', 'C')