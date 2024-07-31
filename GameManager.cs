using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public List<Player> players = new List<Player>();
    public CardData[] deck;
    public int[] startingHandSize = { 0, 15, 14, 14, 14 };

    void Start()
    {
        InitializeGame();
    }

    void InitializeGame()
    {
        for (int j=1;j<= 4; j++)
        {
            players[j].hand.Clear();

            for (int i = 0; i < startingHandSize[j]; i++)
            {
                CardData card = DrawCard();
                players[j].hand.Add(card);
            }
        }
    }

    CardData DrawCard()
    {
        if (deck.Length > 0)
        {
            CardData drawnCard = deck[0];
            List<CardData> tempDeck = new List<CardData>(deck);
            tempDeck.RemoveAt(0);
            deck = tempDeck.ToArray();

            return drawnCard;
        }

        return null;
    }

}
