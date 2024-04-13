# összegzés tétele (mit csinálunk + kód)
# sorozat elemeit összeadjuk

S = [1, 2, 3, 4, 5, 6]
def osszegzes(S):
    sum = 0
    for i in range(len(S)):
        sum += S[i]
    return sum

print(osszegzes(S))