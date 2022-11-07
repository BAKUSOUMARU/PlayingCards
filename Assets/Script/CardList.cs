using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/CardList")]
public class CardList : ScriptableObject
{
    public List<CardListRecord> CardLists = new List<CardListRecord>();
    
    public enum CardType
    {
        Spade,
        Club,
        Dia,
        Heart,
        joker
    }

    [Serializable]
    public class CardListRecord
    {
        public CardType cardType ;
        public int cardNumber;
    }
}
