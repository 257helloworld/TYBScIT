# Derive the expression based on
# a. Associative Law
# b. Distributive Law

a = int(input("First Number: "))
b = int(input("Second Number: "))
c = int(input("Third Number: "))

print("Distributive Law")
print(f"A (B  + C) = {a * (b + c)}")
print(f"AB + AC = {(a * b) + (a * c)}")

print("\nAssociative Law")
print(f"A + (B + C) = {a + (b + c)}")
print(f"(A + B) + C = {(a + b) + c}")
