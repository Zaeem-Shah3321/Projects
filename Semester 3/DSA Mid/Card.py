import random

class cards:
    def __init__(self, suit, value):
        self.suit = suit
        self.value = value
        self.image = f"Resources/{suit}_{value}.png"
        self.backimage = f"Resources/card_back_2.png"
        self.faceup = False
        self.color = 'red' if suit in ['hearts' , 'diamonds'] else 'black'

    def __str__(self):
        return f"{self.suit}_{self.value}"
    
suits = ["hearts", "diamonds", "clubs", "spades"]
values = ["A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"]


deck = []
for i in suits:
    for j in values:
        card = cards(i,j)
        deck.append(card)


random.shuffle(deck)
