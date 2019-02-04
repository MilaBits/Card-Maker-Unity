using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class WindowManager : MonoBehaviour {
    [InlineEditor]
    public Card Card;

    [InlineEditor]
    public List<Card> Collection;

    [Space]
    public CollectionPanel CollectionPanel;

    public void OpenCollectionPanel() {
        CollectionPanel.gameObject.SetActive(true);
        
        CollectionPanel.LoadCards(Collection);
    }

    public void CloseCollectionPanel() {
        CollectionPanel.gameObject.SetActive(false);
    }

}
