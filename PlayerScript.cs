using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public CardScript cardScript;
    public DeckScript deckScript; // these are just calling the other scripts

    public int handValue = 0; // the value of the hand

    private int money = 1000; // cash on hand to start

    public GameObject[] hand; // cards on the table currently

    public int cardIndex = 0;
    public int aceCount = 0;

    List<CardScript> aceList = new List<CardScript>(); // we are keeping track of the cards
    void Start()
    {
        
    }

    public int GetCard()
    {
        int cardValue = deckScript.DealCard(hand[cardIndex].GetComponent<cardScript>());
        
    }
    

}
