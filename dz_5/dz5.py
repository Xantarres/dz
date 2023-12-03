text = "Пример текста для подсчета гласных букв"
vowels = "аеияо"
count = 0
for i in text:
    if i in vowels:
        count += 1
        print("Количество гласных букв:",count)
