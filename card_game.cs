using UnityEngine;
using System.Collections.Generic;



public enum culoare { rosu, galben,albastru, negru }
public enum numar { unu, doi, trei, patru, cinci, sase, sapte, opt, noua, zece, unsprezece, doisprezece, treisprezece}

[System.Serializable]
public class Piatra
{
    public culoare Culoare;
    public numar Valoare;
    public Sprite Image;
}

public class Deck : MonoBehaviour
{
    public List<Piatra> carti;

    public void Amesteca()
    {
        for (int i = 0; i < carti.Count; i++)
        {
            Piatra temp = carti[i];
            int randi = Random.Range(i, carti.Count);
            carti[i] = carti[randi];
            carti[randi] = temp;
        }
    }

    public Piatra Trage_Carte()
    {
        if (carti.Count == 0) return null;
        Piatra piatra = carti[0];
        carti.RemoveAt(0);
        return piatra;
    }
}
