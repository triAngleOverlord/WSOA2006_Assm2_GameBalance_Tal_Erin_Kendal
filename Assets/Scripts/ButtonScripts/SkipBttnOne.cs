using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipBttnOne : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("Tutorial2");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
