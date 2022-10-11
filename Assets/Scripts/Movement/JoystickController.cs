using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private GameObject joyDragButton;
    [SerializeField]
    private float moveRadius;
    [SerializeField]
    public static Vector2 Position
    {
        get {
        return ((Vector2)instance.joyDragButton.transform.position - (Vector2)instance.gameObject.transform.position);
    }
    }
    public static JoystickController instance;

    public void OnDrag(PointerEventData eventData) {
        Vector2 inputPosition = Camera.main.ScreenToWorldPoint(eventData.position);

        Vector2 offset = inputPosition - (Vector2)gameObject.transform.position;
        offset = new Vector2(offset.x, offset.y);

        joyDragButton.gameObject.transform.position = (Vector2)gameObject.transform.position + Vector2.ClampMagnitude(offset, moveRadius);
    }

    public void OnEndDrag(PointerEventData eventData) {
        joyDragButton.transform.localPosition = Vector2.zero;
    }

    private void Start() {
        instance = this;
    }

}
