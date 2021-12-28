using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class peopleCollected : MonoBehaviour
{
    public int peopleCount = 0;
    public int maxPeople = 3;

    [SerializeField] Image[] collectedPeople;
    [SerializeField] Sprite collected;
    [SerializeField] Sprite notCollected;


    void Update()
    {
        for (int i = 0; i < collectedPeople.Length; i++)
        {
            if (i < peopleCount)
            {
                collectedPeople[i].sprite = collected;
            }
            else
            {
                collectedPeople[i].sprite = notCollected;
            }
            if (i < maxPeople)
            {
                collectedPeople[i].enabled = true;
            }
            else
            {
                collectedPeople[i].enabled = false;
            }

        }

    }
}
