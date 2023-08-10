using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Tile : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    Transform parentAfterDrag;

    public Transform ParentAfterDrag //The transform of the parent inventory slot allowing the item
                                     //we are dragging to be placed in the same position as the inventory slot it is left on
    {
        get { return parentAfterDrag; }
        set { parentAfterDrag = value; }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            GetComponent<Image>().raycastTarget = false;
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            transform.position = Input.mousePosition;
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            transform.SetParent(parentAfterDrag);
            GetComponent<Image>().raycastTarget = true;
        }
    }


}
