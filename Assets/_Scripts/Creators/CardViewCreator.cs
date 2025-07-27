using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CardViewCreator : Singleton<CardViewCreator>
{
    [SerializeField]private CardView cardViewPrefab;

    public CardView CreateCardView(Card card,Vector3 position, Quaternion rotation)
    {
        CardView cardView = Instantiate(cardViewPrefab, position, rotation);
        cardView.transform.localScale = Vector3.one;
        cardView.transform.DOScale(Vector3.one, 0.15f);
        cardView.SetUp(card);
        return cardView;
    }
}
