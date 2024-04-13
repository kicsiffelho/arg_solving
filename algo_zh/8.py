# lineáris keresés

S = [1, 2, 3, 4, 5, 6]

def lin_kereses(S, n):
    i = 0
    while i < len(S) and S[i] != n:
        i += 1
    return i < len(S)

print(lin_kereses(S, 7))