using UnityEngine;

public class OKButton : MonoBehaviour
{
    public GameManager manager;
    public void OnPlayButton()
    {
        manager.changeLevel(1);
    }

    // Start is called before the first frame update
    void Awake()
    {

        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
