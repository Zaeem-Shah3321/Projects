#include <iostream>
#include <ctime>
using namespace std;

void ludo(int player1, int player2);
int dice();
int position(int currentPosition, int dice);
int SIZE = 10;
main() 
{
    srand(time(NULL));
    int player1 = 0; 
    int player2 = 0;

    while (player1 < 100 && player2 < 100)
    {
        int p1;
        cout << "Player 1, press 1 to roll the dice: ";
        cin >> p1;
        int dice1;
        if(p1 == 1)
        {
            dice1 = dice();
            cout << "Player 1 rolled a " << dice1 << endl;
            player1 = position(player1, dice1);
            ludo(player1, player2);
            if (player1 == 100)
            {
                cout << "Player 1 wins!" << endl;
                break;
            }
        }

        int p2;
        cout << "Player 2, press 2 to roll the dice: ";
        cin >> p2;
        int dice2;
        if (p2 == 2)
        {
            dice2 = dice();
            cout << "Player 2 rolled a " << dice2 << endl;
            player2 = position(player2, dice2);
            ludo(player1, player2);
            if (player2 == 100) 
            {
                cout << "Player 2 wins!" << endl;
                break;
            }
        }
    }
    return 0;
}
void ludo(int player1, int player2)
{
    int ludo[SIZE][SIZE];

    int count = 100;
    for (int x = 0 ; x < SIZE; ++x) 
    {
        for (int y = 0 ; y < SIZE ;y++)
        {
            ludo[x][y] = count --;
        }
    }

    ludo[SIZE - 1 - (player1 / SIZE)][(player1 % SIZE)] = -1; 
    ludo[SIZE - 1 - (player2 / SIZE)][(player2 % SIZE)] = -2; 

    for (int i = 0; i < SIZE; ++i) 
    {
        for (int j = 0 ; j < SIZE ; ++j) 
        {
            if (ludo[i][j] == -1) {
                cout << "(X)\t";
            } 
            else if (ludo[i][j] == -2) 
            {
                cout << "(Y)\t";
            } 
            else 
            {
                cout << ludo[i][j] << "\t"; 
            }
        }
        cout << endl;
    }
}

int dice() {
    return (rand() % 6) + 1;
}

int position(int currentPosition, int dice) 
{

    int ladderStart[] = {3, 17, 14};
    int ladderEnd[] = {38, 68, 59};
    int snakeStart[] = {31, 40, 50};
    int snakeEnd[] = {4, 18, 22};

    for (int i = 0; i < sizeof(ladderStart) / sizeof(ladderStart[0]); ++i) 
    {
        if (currentPosition == ladderStart[i]) 
        {
            currentPosition = ladderEnd[i];
            break;
        }
    }

    for (int i = 0; i < sizeof(snakeStart) / sizeof(snakeStart[0]); ++i) 
    {
        if (currentPosition == snakeStart[i]) 
        {
            currentPosition = snakeEnd[i];
            break;
        }
    }

    currentPosition += dice;

    if (currentPosition > 100) 
    {
        currentPosition -= dice;
    }
    return currentPosition;
}