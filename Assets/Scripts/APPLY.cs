using UnityEngine;

public class APPLY : MonoBehaviour
{
    public GameManager Manager;
    public void Awake()
    {
        Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void applyFunc()
    {
        Manager.checkSequence();
    }
}
