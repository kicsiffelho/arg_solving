# eldöntés tétele
# bool értéket add vissza aszerint, hogy a sorozat elemei megfelelnek-e egy adott tulajdonságnak, addig vizsgáljuk a sorozat elemeit,
# amíg nem találunk egy megfelelőt

S = [1, 2, 3]

def paros(S):
    for i in range(len(S)):
        if S[i] % 2 == 0:
            return True
    return False
    
print(paros(S))