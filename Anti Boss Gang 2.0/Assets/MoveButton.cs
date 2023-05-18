using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Vector2 pointerOffset;
    private RectTransform buttonRectTransform;

    void Start()
    {
        buttonRectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        pointerOffset = (Vector2)data.position - buttonRectTransform.anchoredPosition;
    }

    public void OnDrag(PointerEventData data)
    {
        buttonRectTransform.anchoredPosition = data.position - pointerOffset;
    }

    public void OnPointerUp(PointerEventData data)
    {
        if (this.gameObject.name == "Jump")
        {
            PlayerPrefs.SetFloat("JBX", this.gameObject.transform.localPosition.x);
            PlayerPrefs.SetFloat("JBY", this.gameObject.transform.localPosition.y);
        }
        if (this.gameObject.name == "Joystick")
        {
            PlayerPrefs.SetFloat("FJX", this.gameObject.transform.localPosition.x);
            PlayerPrefs.SetFloat("FJY", this.gameObject.transform.localPosition.y);
        }
    }
}
