using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelSwitching : MonoBehaviour
{
    public List<Image> bookImages = new List<Image>();
    
    //list for all the images with labels for the buttons in the book to reference
    //one list for each symbol button with the 3 color variations
    //button pressing will cycle through the color variations

    //wand will apply label and close book increases currentLabel amount on GameManager
    //button to make no label which decreases currentLabel amount on GameManager
    //label must not work if the max labels have been reached


    //BUTTON FUNCTIONS
    //currentTile.sprite = labslList[2]
}
