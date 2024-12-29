import random
import string
from time import sleep

allChars = string.ascii_letters + string.punctuation + string.digits 
target = "Hello World!"
current = ""

for i in target:
    choise = ""
    if i != " ":
        while choise != i:
            choise = random.choice(allChars)
            print(current + choise)
            # sleep(0.01)
    current += i
