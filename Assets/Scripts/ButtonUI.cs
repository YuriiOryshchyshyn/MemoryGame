using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x + 0.02f, transform.localScale.y + 0.02f, transform.localScale.z);
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(transform.localScale.x - 0.02f, transform.localScale.y - 0.02f, transform.localScale.z);

        targetObject.SendMessage(targetMessage);
    }
}
