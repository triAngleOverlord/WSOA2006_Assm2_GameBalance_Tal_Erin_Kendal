using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LabelSwitching : MonoBehaviour
{
    [SerializeField] Sprite greenEgg,blueEgg,greenCandy,blueCandy,greenTooth,blueTooth,greenBeetle,
                            blueBeetle,greenPlant,bluePlant,greenWing,blueWing,greenVile,blueVile,greenEye,blueEye;

    [SerializeField] GameObject book;
    [SerializeField] GameObject selectionBox;


    public void GreenEgg()
    {
        GameManager.Instance.currentTile.sprite = greenEgg;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void BlueEgg()
    {
        GameManager.Instance.currentTile.sprite = blueEgg;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void GreenCandy()
    {
        GameManager.Instance.currentTile.sprite = greenCandy;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void BlueCandy()
    {
        GameManager.Instance.currentTile.sprite = blueCandy;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void GreenTooth()
    {
        GameManager.Instance.currentTile.sprite = greenTooth;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void BlueTooth()
    {
        GameManager.Instance.currentTile.sprite = blueTooth;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void GreenBeetle()
    {
        GameManager.Instance.currentTile.sprite = greenBeetle;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void BlueBeetle()
    {
        GameManager.Instance.currentTile.sprite = blueBeetle;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void GreenPlant()
    {
        GameManager.Instance.currentTile.sprite = greenPlant;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void BluePlant()
    {
        GameManager.Instance.currentTile.sprite = bluePlant;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void GreenWing()
    {
        GameManager.Instance.currentTile.sprite = greenWing;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void BlueWing()
    {
        GameManager.Instance.currentTile.sprite = blueWing;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void GreenVile()
    {
        GameManager.Instance.currentTile.sprite = greenVile;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void BlueVile()
    {
        GameManager.Instance.currentTile.sprite = blueVile;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void GreenEye()
    {
        GameManager.Instance.currentTile.sprite = greenEye;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }

    public void BlueEye()
    {
        GameManager.Instance.currentTile.sprite = blueEye;
        book = GameObject.Find("Book");
        selectionBox = GameManager.Instance.currentTile.transform.GetChild(0).gameObject;
        book.SetActive(false);
        selectionBox.SetActive(false);
    }




}
