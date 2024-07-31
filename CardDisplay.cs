using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public CardData card;
    public Image CardColour;
    void Start()
    {
        CardColour.sprite = card.card_afis;
    }

    
}
