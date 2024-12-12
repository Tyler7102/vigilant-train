using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{
    public Sprite[] cardSprites;  // can access sprites
    int[] cardValues = new int[53];  // assign value 2 cards
    int currentIndex = 0; // where we're at in the deck
    void Start()
    {
        
    }

    void GetCardValues()
    {
        int num = 0;
        for (int i = 0; i < cardSprites.Length; i++) // using a loop to attach a value to each card
        {
            num = i;
            num%= 13; // 13 cards per deck, helps once we go past the first 13 into another suit
            if(num > 10 || num == 0) // seperates the number cards from the face cards
            {
                num = 10; // assigns a value of 10 to face cards if the chosen card is one
            }
            cardValues[i] = num++;
        }
        currentIndex = 1; // keeps track of value
    }

    public void Shuffle();  // shuffling the cards
    {
        for(int i = cardSprites.Length -1; i > 0; --i) // counting backwards
        {
            int j = Mathf.FloorToInt(Random.Range(0.0f, 1.0f) * cardSprites.Length - 1) + 1; // gets us a random number in the deck
            Sprite face = cardSprites[i]; // assign
            cardSprites[i] = cardSprites[j]; // swap i and j
            cardSprites[j] = face; // swap i and j's place

            int value = cardValues[i]; // same as above
            cardValues[i] = cardValues[j];
            cardValues[j] = value;
        }
    }

    public int DealCard(CardScript cardScript) // deals us a card
    {
        cardScript.SetSprite(cardSprites[currentIndex]);
        cardScript.SetValue(cardValues[currentIndex]);
        currentIndex++; // helps us add to the current index
        return cardScript.GetValueOfCard(); // gives the value of the card we have during the hand
    }

    public Sprite GetCardBack() // we know what happens at 0
    {
        return cardSprites[0];
    }
}
