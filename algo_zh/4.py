# megszámlálás tétele
# megszámoljuk a sorozat elmeit

S = [1, 2, 3, 4, 5, 6]
def megszamlalas(S):
    counter = 0
    for i in range(len(S)):
        counter += 1
    return counter

print(megszamlalas(S))