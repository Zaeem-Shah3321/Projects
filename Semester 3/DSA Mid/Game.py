import tkinter as tk
import Card as cd
from tkinter import PhotoImage
from PIL import ImageTk, Image
from Stack import stack

window = tk.Tk()
window.title("Solitaire 2.0")
window.state('zoomed')
window.configure(bg="dark green")
image_w = 90
image_h = 130
tableau_stacks = [stack() for _ in range(7)]
card_ref = []  
curren_index = -1  
face_up_labels = []
foundation = []
foundation_labels = []

lbl = None


def tableau(deck):
    placeholders()
    xs = 400
    ys = 30
    for i in range(7):
        for j in range(i + 1):
            card = deck.pop()
            card.faceup = False
            tableau_stacks[i].push(card)
    
    for i in range(7):
        current_stack = tableau_stacks[i].copy()
        ys = 30
        while not current_stack.isEmpty():
            card = current_stack.pop()
            if current_stack.isEmpty():
                card.faceup = True
            img = Image.open(card.image if card.faceup else card.backimage)
            img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
            tk_img = ImageTk.PhotoImage(img)
            label = tk.Label(window, image=tk_img)
            label.image = tk_img  
            label.place(x=xs, y=ys)
            lbl = label
            ys += 30
        xs += 120
        label.bind('<Double-Button-1>', lambda event, lbl=label, crd=card: move(lbl, crd))

def card_stack(deck):
    resetpic()
    for card in deck:
        card_ref.append(card)
        img = Image.open(card.backimage)
        img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
        tk_img = ImageTk.PhotoImage(img)
        label = tk.Label(window, image=tk_img)
        label.image = tk_img
        label.bind("<Button-1>", lambda event, lbl=label, crd=card: flip_card(lbl, crd))
        label.place(x=50, y=30)

def flip_card(label, card): 
    global curren_index
    if curren_index < len(card_ref):
        card.faceup = True
        img = Image.open(card.image)
        img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
        tk_img = ImageTk.PhotoImage(img)
        label.configure(image=tk_img)
        label.image = tk_img
        label.place(x=150, y=30)
        label.lift() 
        label.unbind("<Button-1>")
        label.bind('<Double-Button-1>', lambda event, lbl=label, crd=card: move(lbl, crd))
        
        face_up_labels.append(label)
        curren_index += 1
    if curren_index == 25: 
        label.destroy()
        reset_deck()

def update_card_visual(stack_index):
    xs = 400 + (stack_index * 120)
    ys = 30
    current_stack = tableau_stacks[stack_index].copy()
    
    cards_count = 0
    temp_stack = current_stack.copy()
    while not temp_stack.isEmpty():
        temp_stack.pop()
        cards_count += 1
    
    final_ys = ys + (30 * (cards_count - 1))
    
    top_card = tableau_stacks[stack_index].peek()
    img = Image.open(top_card.image)
    img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
    tk_img = ImageTk.PhotoImage(img)
    label = tk.Label(window, image=tk_img)
    label.image = tk_img
    label.place(x=xs, y=final_ys)
    label.bind('<Double-Button-1>', lambda event, lbl=label, crd=top_card: move(lbl, crd))


def move(label, card: cd.cards):
    global foundation, foundation_labels
    source_stack_index = -1
    for i, stack in enumerate(tableau_stacks):
        current = stack.head.next
        while current:
            if current.value == card:
                source_stack_index = i
                break
            current = current.next
        if source_stack_index != -1:
            break

    moved = False
    if card.suit == 'hearts' and card.value == 'A':
        label.place(x=50, y=300)
        moved = True
    elif card.suit == 'spades' and card.value == 'A':
        label.place(x=200, y=300)
        moved = True
    elif card.suit == 'diamonds' and card.value == 'A':
        label.place(x=200, y=500)
        moved = True
    elif card.suit == 'clubs' and card.value == 'A':
        label.place(x=50, y=500)
        moved = True

    if moved:
        foundation.append(card)
        foundation_labels.append(label)

        if source_stack_index != -1:
            tableau_stacks[source_stack_index].remove_card(card)
    
            if not tableau_stacks[source_stack_index].isEmpty():
                top_card = tableau_stacks[source_stack_index].peek()
                if not top_card.faceup:
                    top_card.faceup = True
            
                    update_card_visual(source_stack_index)

    label.lift()
    refresh()

def refresh():
    for i in range(0,6):
        if tableau_stacks[i].peek().faceup == False:
            flip_card(lbl,tableau_stacks[i].peek()) 
            

def reset_deck():
    global curren_index
    curren_index = 0
    for card in card_ref:
        if card not in foundation:
            card.faceup = False  
    for label in face_up_labels:
        if label not in foundation_labels:
            label.destroy()
    face_up_labels.clear()
    for card in card_ref:
        if card not in foundation:
            img = Image.open(card.backimage)
            img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
            tk_img = ImageTk.PhotoImage(img)
            label = tk.Label(window, image=tk_img)
            label.image = tk_img
            label.bind("<Button-1>", lambda event, lbl=label, crd=card: flip_card(lbl, crd))
            label.place(x=50, y=30)

def placeholders():
    img = Image.open("Resources/clubs_slot.png")
    img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
    tk_img = ImageTk.PhotoImage(img)
    label = tk.Label(window, image=tk_img)
    label.image = tk_img  
    label.place(x=50, y=500)

    img = Image.open("Resources/diamonds_slot.png")
    img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
    tk_img = ImageTk.PhotoImage(img)
    label = tk.Label(window, image=tk_img)
    label.image = tk_img  
    label.place(x=200, y=500)

    img = Image.open("Resources/spades_slot.png")
    img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
    tk_img = ImageTk.PhotoImage(img)
    label = tk.Label(window, image=tk_img)
    label.image = tk_img  
    label.place(x=200, y=300)

    img = Image.open("Resources/hearts_slot.png")
    img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
    tk_img = ImageTk.PhotoImage(img)
    label = tk.Label(window, image=tk_img)
    label.image = tk_img  
    label.place(x=50, y=300)

def resetpic():
    img = Image.open('Resources/empty_slot.png')
    img = img.resize((image_w, image_h), Image.Resampling.LANCZOS)
    tk_img = ImageTk.PhotoImage(img)
    label = tk.Label(window, image=tk_img)
    label.image = tk_img  
    label.bind("<Button-1>", lambda event,: reset_deck())
    label.place(x=50, y=30)

if __name__ == "__main__":
    tableau(cd.deck)
    card_stack(cd.deck)
    window.mainloop()