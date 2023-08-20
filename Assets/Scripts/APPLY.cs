using UnityEngine;

public class APPLY : MonoBehaviour
{
    // Start is called before the first frame update
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
