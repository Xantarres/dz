a=int(input("Введите первое число:"))
b=int(input("Введите второе число:"))
def sum():
    print("Ответ : ", a + b)
def vichitanie():
    print("Ответ : ", a - b)
def ymn():
    print("Ответ : ", a * b)
def delenie():
    print("Ответ : ", a / b)
def error():
    print("У вас ошибка при вводе, перезапустите программу")
print("Обратите внимание сейчас будет пояснение по знакам в калькуляторе")
print('Знак сложения +')
print('Знак вычетания -')
print('Знак умножения *')
print('Знак деления :')
input=input("Введите знак ")
if input =="+" :
    sum()
elif input=="-" :
    vichitanie()
elif input=="*" :
    ymn()
elif input==":" :
    delenie()
else:
    error()