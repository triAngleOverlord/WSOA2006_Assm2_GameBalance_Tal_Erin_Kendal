using UnityEngine;
using UnityEngine.EventSystems;

public class GridSlot : MonoBehaviour, IDropHandler
{
    public GameManager.Symbol symbol;
    public bool sequenceBL;
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject droppedTile = eventData.pointerDrag;
            Tile tile = droppedTile.GetComponent<Tile>();
            if (tile.mouseOverTile==true)
            {
                tile.ParentAfterDrag = transform;

                if (sequenceBL == true)
                {
                    symbol = tile.symbol;
                }

            }
            

        }

    }
}
