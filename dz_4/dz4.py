N = int(input())
k = int(input()) - 1
people = list(range(1,N+1))
while len(people) !=1:
    index = k%len(people)
    k = index
    del people[k]
    k += 2
    print(people)