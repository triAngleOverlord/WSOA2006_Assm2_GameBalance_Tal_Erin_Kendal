using System.Collections;
using UnityEngine;

public class Incorrect : MonoBehaviour
{
    public void Awake()
    {
        StartCoroutine(incorrectLiveTime());
    }

    public IEnumerator incorrectLiveTime()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
