# kiválogatás tétele
# kiválogatjuk egy másik tömbbe a sorozat azon elemeit, amelyek a feltételnek megfelelnek

S = [1, 2, 3, 4, 5, 6]
def paros(n):
    return n%2==0

def kivalogatas(S,T, f):
    for i in range(len(S)):
        if f(S[i]):
            T.append(S[i])
    return T

print(kivalogatas(S, [], paros))
