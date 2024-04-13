# min érték első előfordulási helyének meghatározása
# meghatározzuk a sorozat legkisebb elemének a helyét

S = [2, 3, 4, 1, 5, 6]
def min_ertek_hely_kivalasztasa(S):
    min = 0
    for i in range(1, len(S)):
        if S[i] < S[min]:
            min = i
    return min

print(min_ertek_hely_kivalasztasa(S))