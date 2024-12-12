using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    // will act as storage for the cards
    public int value = 0;

    public int GetValueOfCard() // give us a number
    {
        return value;
    }

    public void SetValue(int newValue) // the card will be THIS card's value
    {
        value = newValue;
    }

    public string GetSpriteName() // give us the name of the sprite/card
    {
        return GetComponent<SpriteRenderer>().sprite.name;
    }

    public void SetSprite(Sprite newSprite)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
    }

    public void ResetCard() // give us a new hand
    {
        Sprite back = GameObject.Find("DeckController").GetComponent<DeckScript>().GetCardBack();
        gameObject.GetComponent<SpriteRenderer>().sprite = back;
        value = 0;
    }
}
