using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public static class IsOverUIObject
{
    public static bool IsTouchOverUIObject()
    {
        List<RaycastResult> results = new List<RaycastResult>();
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
            eventDataCurrentPosition.position = new Vector2(touch.position.x, touch.position.y);
            EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        }
        return results.Count > 0;
    }
}
