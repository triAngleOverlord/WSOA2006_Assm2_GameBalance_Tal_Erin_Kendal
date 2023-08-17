using UnityEngine;

public class PixelToWorld : MonoBehaviour
{
    public Vector2 WorldUnitsInCamera;
    public Vector2 WorldToPixelAmount;

    public Camera Camera;

    public void Awake()
    {
        Camera = Camera.main;
        Debug.Log("Camera");
        
        //Finding Pixel To World Unit Conversion Based On Orthographic Size Of Camera
        WorldUnitsInCamera.y = Camera.GetComponent<Camera>().orthographicSize * 2;
        WorldUnitsInCamera.x = WorldUnitsInCamera.y * Screen.width / Screen.height;

        WorldToPixelAmount.x = Screen.width / WorldUnitsInCamera.x;
        WorldToPixelAmount.y = Screen.height / WorldUnitsInCamera.y;
    }


    //Taking Your Camera Location And Is Off Setting For Position And For Amount Of World Units In Camera
    public Vector2 ConvertToWorldUnits(Vector2 TouchLocation)
    {
        Vector2 returnVec2;

        returnVec2.x = ((TouchLocation.x / WorldToPixelAmount.x) - (WorldUnitsInCamera.x / 2)) +
        Camera.transform.position.x;
        returnVec2.y = ((TouchLocation.y / WorldToPixelAmount.y) - (WorldUnitsInCamera.y / 2)) +
        Camera.transform.position.y;

        return returnVec2;
    }

    ///script reference: Healyourself, 18 March 2017; Pixel To World Unit Conversion; Forums, Unity; https://forum.unity.com/threads/pixel-to-world-unit-conversion.461640/
}



