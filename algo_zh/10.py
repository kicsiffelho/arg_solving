# bináris keresés -> [2, 6, 8, 11, 13, 21, 72, 84, 90] keresett érték: 8 + algo ábra

S = [2, 6, 8, 11, 13, 21, 72, 84, 90]
def bin_kereses(S, n):
    a = 0
    f = len(S) - 1
    k = (a + f) // 2
    while a <= f and S[k] != n:
        if n < S[k]:
            f = k - 1
        else:
            a = k + 1
        k = (a + f) // 2
    return a <= f and S[k] == n

print(bin_kereses(S, 8))