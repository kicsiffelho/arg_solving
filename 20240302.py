# print("Hello World!")

# def main():
#     print("Hello", end=" ")
#     print("Anikó!")
#
# if __name__ == "__main__":
#     main()

# y = 2.8
# x = 1
#
# # convert from in to float:
# a = float(x)
# # convert from float to int:
# b = int(y)
# # convert from int to complex:
# c = complex(x)
#
# print(a)
# print(b)
#
# print(type(a))
# print(type(b))

# for x in "banana":
#     print(x.upper(), end=" ")

# txt = "Hello world!"
#
# for x in txt:
#     print(x, len(txt))

# txt = "The best things in life are free!"
#
# if "free" in txt:
#     print("Yes, 'free' is present.")
# else: print("No, 'free' is not present")

# a = "Hello, world"
# print(a.split(", "))

# age = 36
# txt = "My name is John and I am {}"
# print(txt.format(age))
#
# quantity = 3
# itemno = 567
# price = 49.95
# myorder = "I want {} pieces of item {} for {} dollars"
# print(myorder.format(quantity,itemno,price))

# thislist = ["apple", "mango", "banana", "blueberry", "grape", "peach", "kiwi"]
# print(thislist[2:5])
# print(thislist[:4])
# print(thislist[-4:-1])
# print(thislist[1:5:2])
# print(thislist[::-1])

# thislist = ["apple", "mango", "cherry"]
# thislist.insert(2, "watermelon")
# print(thislist)
#
# thislist.append("orange")
# print(thislist)
#
# thislist.remove("apple")
# print(thislist)
#
# for x in thislist:
#     print(x, end=", ")

# thisdict = {
#     "brand": "Ford",
#     "model": "Mustang",
#     "year": 1964
# }
# print(thisdict)
# print(thisdict["brand"])
# print(len(thisdict))
#
# for x in thisdict:
#     print(thisdict[x])
#
# for x in thisdict.keys():
#     print(x)
#
# for x,y in thisdict.items():
#     print(x,y)
#
# for x in thisdict.values():
#     print(x)

# def get_grades(name):
#     marks = {"James": 90, "Jules": 55, "Arthur": 77}
#
#     for student in marks:
#         if student == name:
#             print(marks[student])
#             break
#     else: print("No entry with that name found")
#
# if __name__ == "__main__":
#     print("Math test results")
#     students_name = input("Type student's name: ")
#     get_grades(students_name)

# def is_haromszog(a,b,c):
#     if (a**2 + b**2 == c**2 and a**2 + b**2 < c**2 or a**2 + b**2 > c**2):
#         return print("A háromszög szerkeszthető")
#     else: return print("A háromszög nem szerkeszthető")
#
# is_haromszog(2,2,2)

# def min_ertek_kereses(S):
#     min_elem = S[0]
#     print("kezdőérték: ", min_elem)
#     for i in range(1, len(S)):
#         if (S[i] < min_elem):
#             min_elem = S[i]
#             print("akutális min érték: ", min_elem)
#     return min_elem
#
#
# def max_ertek_kereses(S):
#     max_elem = S[0]
#     print("kezdőérték: ", max_elem)
#     for i in range(1, len(S)):
#         if (S[i] > max_elem):
#             max_elem = S[i]
#             print("akutális max érték: ", max_elem)
#     return max_elem
#
# S = [4,5,3,6,7,5,1]
# min_ertek_kereses(S)
# max_ertek_kereses(S)