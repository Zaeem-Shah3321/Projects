from Card import cards

class Node:
    def __init__(self, value:cards):
        self.value = value
        self.next = None

class stack:
    def __init__(self):
        self.head = Node("head") 
        self.size = 0

    def __str__(self):
        values = []
        current = self.head.next
        while current:
            values.append(str(current.value))
            current = current.next
        return " ".join(values)

    def peek(self)->cards:
        if self.isEmpty():
            print ("Empty")
        return self.head.next.value 
    

    def len(self):
        return self.size

    def isEmpty(self):
        return self.size == 0

    def display(self):
        if self.isEmpty():
            return None
        return self.head.next.value

    def push(self, value):
        node = Node(value)
        node.next = self.head.next 
        self.head.next = node 
        self.size += 1

    def pop(self):
        if self.isEmpty():
            raise Exception("Popping from an empty stack")
        remove = self.head.next
        self.head.next = remove.next 
        self.size -= 1
        return remove.value

    def copy(self):
        new_stack = stack()
        current = self.head.next
        temp_list = []

        while current:
            temp_list.append(current.value)  
            current = current.next

        for value in reversed(temp_list):
            new_stack.push(value)  

        return new_stack

    def remove_card(self, card):
        if self.isEmpty():
            return
        
        current = self.head
        while current.next and current.next.value != card:
            current = current.next
        
        if current.next:
            current.next = current.next.next
            self.size -= 1