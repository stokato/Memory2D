using UnityEngine;
using System.Collections;

public class MemoryCard : MonoBehaviour {

    [SerializeField]
    private SceneController controller;

    [SerializeField]
    private GameObject cardBack;

    private int _id;
    public int id
    {
        get { return _id; }
    }

    public void SetCard(int id , Sprite image)
    {
        _id = id;

        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void OnMouseDown()
    {
        if(cardBack.activeSelf && controller.canReveal) 
        {
            cardBack.SetActive(false); // Деактивирует объект, делая его невидимым
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }

}
