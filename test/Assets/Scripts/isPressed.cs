using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class isPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool IsPressed = false;
    // Start is called before the first frame update

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        IsPressed = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    { IsPressed = false; 
    }
}
