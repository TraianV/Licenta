using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Rummy/CardData")]
public class CardData : ScriptableObject
{
    public string cardName;
    public Sprite card_afis; 
    public string rank; 
}