import Sortings as str
from Binary_Search import BinarySearchTree

contacts = [

    {"Name": "Alice", "Phone": "12345627890", "Email": "alice.smith@gmail.com"},
    {"Name": "Bob", "Phone": "23456728901", "Email": "bob.johnson@gmail.com"},
    {"Name": "Charlie", "Phone": "34567829012", "Email": "charlie.brown@gmail.com"},
    {"Name": "David", "Phone": "45678920123", "Email": "david.wilson@gmail.com"},
    {"Name": "Eve", "Phone": "56718911234", "Email": "eve.davis@gmail.com"},
    {"Name": "Franky", "Phone": "67819012345", "Email": "frank.miller@gmail.com"},
    {"Name": "Grace", "Phone": "78910123456", "Email": "grace.lee@gmail.com"},
    {"Name": "Hank", "Phone": "89041234567", "Email": "hank.taylor@gmail.com"},
    {"Name": "Ivy", "Phone": "90172345678", "Email": "ivy.martinez@gmail.com"},
    {"Name": "Jack", "Phone": "01263456789", "Email": "jack.anderson@gmail.com"}
]

def data():
    flag = False
    flag2 = False
    while True:
        name = input("Enter Name: ")
        phone = input("Enter Phone Number: ")
        email = input("Enter Email: ")
        flag = valid_phone(phone)
        flag2 = valid_email(email)
        if flag and flag2:
            contacts.append({"Name": name, "Phone": phone, "Email": email})
            print ("Added Sucessfully...")
            break
        elif flag and (not(flag2)):
            print("Invalid Email")
        elif (not(flag)) and flag2:
            print("Invalid Phone Number")
        elif (not(flag)) and (not(flag2)):
            print("Invalid Phone Number And Email")

def valid_phone(phone):
    flag = False
    if len(phone) == 11:
        flag = True
    return flag

def valid_email(email):
    if email.endswith("@gmail.com"):
        before = email.split("@")[0]
        if before:
            return True
    return False

def show(): 
    if not contacts:
        print("No contacts to display!")
    else:
        print("All Contacts:")
        for contact in contacts:
            print(f"Name: {contact['Name']}, Phone: {contact['Phone']}, Email: {contact['Email']}")

def sorting():
    while True:
        flag1= True
        flag2= True

        print("Chose Sorting Method")
        print("1. Bubble Sort")
        print("2. Selection Sort")
        print("3. Insertion Sort")
        print("4. Merge Sort")
        print("5. Quick Sort")
        inp = int(input("Enter Your Choise: "))

        print("Chose Attribute")
        print("1. Name")
        print("2. Phone Number")
        print("3. Email")
        ipt = int(input("Enter Your Choise: "))

        if inp > 5:
            print("Invalid Sorting Number...")
            flag1 = False
        if ipt > 3:
            print("Invalid Attribute Number...")
            flag2 = False

        if flag1 and flag2:
                send(inp, ipt)
                break

def send(s_i , a_i):
    arr = []
    contact_copy = contacts.copy()
    if a_i == 1:
        if s_i == 1:
            arr = str.bubble_sort(contacts,"Name")
        elif s_i == 2:
            arr = str.selection_sort(contacts,"Name")
        elif s_i == 3:
            arr = str.insertion_sort(contacts,"Name")
        elif s_i == 4:
            arr = str.merge_sort(contacts,"Name")
        elif s_i == 5:
            str.quick_sort(contact_copy,0,len(contact_copy) - 1,"Name")
    elif a_i == 2:
        if s_i == 1:
            arr = str.bubble_sort(contacts,"Phone")
        elif s_i == 2:
            arr = str.selection_sort(contacts,"Phone")
        elif s_i == 3:
            arr = str.insertion_sort(contacts,"Phone")
        elif s_i == 4:
            arr = str.merge_sort(contacts,"Phone")
        elif s_i == 5:
            str.quick_sort(contact_copy,0,len(contact_copy) - 1,"Phone")
    elif a_i == 3:
        if s_i == 1:
            arr = str.bubble_sort(contacts,"Email")
        elif s_i == 2:
            arr = str.selection_sort(contacts,"Email")
        elif s_i == 3:
            arr = str.insertion_sort(contacts,"Email")
        elif s_i == 4:
            arr = str.merge_sort(contacts,"Email")
        elif s_i == 5:
            str.quick_sort(contact_copy,0,len(contact_copy) - 1,"Email")
    
    if s_i == 5:
        display_quick(contact_copy)
    else:
        display(arr)

def display(arr):
    for contact in arr:
            print(f"Name: {contact['Name']}, Phone: {contact['Phone']}, Email: {contact['Email']}")

def display_quick(contact_copy):
    for contact in contact_copy:
            print(f"Name: {contact['Name']}, Phone: {contact['Phone']}, Email: {contact['Email']}")

def search():
    bst = BinarySearchTree()
    for obj in contacts:
        bst.insert(obj["Name"], obj)
        bst.insert(obj["Email"], obj)
    ipt = input("Enter Attribute (1 for Name , 2 for Email): ")
    if ipt == "1":
        name = input("Enter Name: ")
        objt = bst.search(name)    
        if objt:
            print(f"Found: Name: {objt['Name']}, Phone: {objt['Phone']}, Email: {objt['Email']}")
        else:
            print(f"No contact found with the name '{name}'.")

    elif ipt == "2":
        mail = input("Enter Email: ")
        objt = bst.search(mail)    
        if objt:
            print(f"Found: Name: {objt['Name']}, Phone: {objt['Phone']}, Email: {objt['Email']}")
        else:
            print(f"No contact found with the name '{name}'.")

def options():
    while True:
        print("1. Add")
        print("2. Show")
        print("3. Sort")
        print("4. Search")
        i = input("Your Choise: ")
        if i == "1":
            data()
        elif i == "2":
            show()
        elif i == "3":
            sorting()   
        elif i == "4":
            search()         
        else:
            print("Invalid Option...")

if __name__ == "__main__":
    options()