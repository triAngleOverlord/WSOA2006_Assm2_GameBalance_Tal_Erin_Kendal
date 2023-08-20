using System.Collections;
using TMPro;
using UnityEngine;

public class Incorrect : MonoBehaviour
{
    public void Awake()
    {
        var text= GameObject.Find("GameManager").transform.GetComponent<GameManager>().sequence;
        var txtx = GameObject.Find("GameManager").transform.GetComponent<GameManager>().submission;
        for (int i = 0; i < text.Count; i++)
        {
            GetComponent<TextMeshProUGUI>().text += text[i] + " and submitted " + txtx[i];
        }

        
        StartCoroutine(incorrectLiveTime());
    }

    public IEnumerator incorrectLiveTime()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
