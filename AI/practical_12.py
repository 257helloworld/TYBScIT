# Derive the expression based on
# a. Associative Law
# b. Distributive Law

a = int(input("First Number: "))
b = int(input("Second Number: "))
c = int(input("Third Number: "))

print("Distributive Law")
print("A (B  + C) = a * (b + c)")
print("AB + AC = " + str((a * b) + (a * c)))

print("\nAssociative Law")
print("A + (B + C) = a + (b + c)")
print("(A + B) + C = " + str((a + b) + c))
