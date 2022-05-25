using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;

    [SerializeField] private GameObject backCard;

    [SerializeField] private SpriteRenderer memoryImage;

    private int _id;
    public int id 
    { 
        get { return _id; } 
    }

    private void OnMouseDown()
    {
        if (backCard.activeSelf && sceneController.canReveal)
        {
            backCard.SetActive(false);
            sceneController.CardRevealed(this);
        }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        memoryImage.sprite = image;
    }

    public void Unreveal()
    {
        backCard.SetActive(true);
    }
}
