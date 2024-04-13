# min érték kiválasztása
# a sorozat legkisebb elemét kiválasztjuk

S = [2, 3, 4, 1, 5, 6]
def min_ertek_kivalasztasa(S):
    min = S[0]
    for i in range(1, len(S)):
        if S[i] < min:
            min = S[i]
    return min

print(min_ertek_kivalasztasa(S))