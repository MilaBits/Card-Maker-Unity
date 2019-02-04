using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionPanel : MonoBehaviour {
    public CardPreview CardPreviewPrefab;
    public RectTransform GridPanel;
    public void LoadCards(List<Card> cards) {

        foreach (GameObject card in GridPanel) {
            Destroy(card);
        }
       
        foreach (Card card in cards) {
            Instantiate(CardPreviewPrefab, GridPanel);
        }
    }
}