using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CardAutoSet : MonoBehaviour
{
      
  
            int card = 0;
    public void CardSet(CardList cardList)
    {

        for (int i = 0; i < 4 - 1; i++)
        {
            for (int n = 0; n < 13; n++)
            {
                var a = (CardList.CardType)i; 
                cardList.CardLists[card].cardType = a;
                cardList.CardLists[card].cardNumber = n;
                card++;
            }
        }
        //cardList.CardLists[52].cardType = CardList.CardType.joker;
        //cardList.CardLists[52].cardNumber = 0;
    }

}
