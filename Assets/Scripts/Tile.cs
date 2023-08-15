using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tile : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    Transform parentAfterDrag;
    PixelToWorld pixelConverter;
    public Rigidbody2D rigidTile;

    public GameManager.Symbol symbol;

    public void OnAwake()
    {
        pixelConverter = GameManager.Instance.pxConverter;
        rigidTile = GetComponent<Rigidbody2D>();
    }
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
            
            if (parentAfterDrag.GetComponent<GridSlot>().sequenceBL == true)
            {
                parentAfterDrag.GetComponent<GridSlot>().symbol = GameManager.Symbol.Nothing;
            }

            transform.SetParent(transform.root, true);
            transform.SetAsLastSibling();
            GetComponent<Image>().raycastTarget = false;
            rigidTile.bodyType = RigidbodyType2D.Dynamic;
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            rigidTile.MovePosition(pixelConverter.ConvertToWorldUnits(Input.mousePosition));
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            transform.SetParent(parentAfterDrag);
            transform.localPosition= Vector2.zero;
            GetComponent<Image>().raycastTarget = true;
            rigidTile.bodyType = RigidbodyType2D.Kinematic;
        }
    }


}
