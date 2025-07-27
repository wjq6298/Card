using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardView : MonoBehaviour
{
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text description;
    [SerializeField] private TMP_Text mana;
    [SerializeField] private SpriteRenderer imageSR;
    [SerializeField] private GameObject wrapper;
    
    public Card Card { get; private set; }

    public void SetUp(Card card)
    {
        Card = card;
        title.text = Card.Title;
        description.text = Card.Description;
        mana.text = Card.Mana.ToString();
        imageSR.sprite = Card.Image;
    }

    private void OnMouseEnter()
    {
        wrapper.SetActive(false);
        Vector3 pos = new(transform.position.x, -2, 0);
        CardViewHoverSystem.Instance.Show(Card,pos);
    }

    private void OnMouseExit()
    {
        CardViewHoverSystem.Instance.Hide();
        wrapper.SetActive(true);
    }
}
