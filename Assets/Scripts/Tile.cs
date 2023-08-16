using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tile : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerClickHandler
{
    Transform parentAfterDrag;
    public PixelToWorld pixelConverter;
    public Rigidbody2D rigidTile;

    public GameManager.Symbol symbol;
    public bool mouseOverTile;

    public bool mouseDirectionCalculated;
    public Vector2 ogMouse;


    public void Start()

    {
        pixelConverter = GameManager.Instance.pxConverter;
        rigidTile = transform.GetComponent<Rigidbody2D>();
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
            detectDirection();
            
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (mouseDirectionCalculated == true)
            {

                rigidTile.MovePosition(pixelConverter.ConvertToWorldUnits(Input.mousePosition));

                Vector2 lp;
                Vector2 mousePos = Input.mousePosition;
                RectTransformUtility.ScreenPointToLocalPointInRectangle(GetComponent<RectTransform>(), mousePos, Camera.main, out lp);

                if (GetComponent<RectTransform>().rect.Contains(lp))
                    mouseOverTile = true;
                else
                    mouseOverTile = false;

            }
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
            mouseDirectionCalculated = false;
            rigidTile.constraints = RigidbodyConstraints2D.None;
            rigidTile.constraints = RigidbodyConstraints2D.FreezeRotation;
            mouseDirectionCalculated = false;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData != null && eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Right click");
        }
    }

    public void detectDirection()
    {
        ogMouse = pixelConverter.ConvertToWorldUnits(Input.mousePosition);
        var mouseChange = pixelConverter.ConvertToWorldUnits(Input.mousePosition);
        var mouseX = Mathf.Abs(ogMouse.x - mouseChange.x);
        var mouseY = Mathf.Abs(ogMouse.y - mouseChange.y);
        while (mouseX < 1 || mouseY < 1)
        {
            mouseChange = pixelConverter.ConvertToWorldUnits(Input.mousePosition);
            mouseX = Mathf.Abs(ogMouse.x - mouseChange.x);
            mouseY = Mathf.Abs(ogMouse.y - mouseChange.y);
        }
        
        if (mouseX > mouseY)
            rigidTile.constraints = RigidbodyConstraints2D.FreezePositionX;
        else if (mouseX < mouseY)
            rigidTile.constraints = RigidbodyConstraints2D.FreezePositionY;

        mouseDirectionCalculated = true;
    }
}
