using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GridSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject droppedTile = eventData.pointerDrag;
            Tile tile = droppedTile.GetComponent<Tile>();
            tile.ParentAfterDrag = transform;
        }

    }
}
