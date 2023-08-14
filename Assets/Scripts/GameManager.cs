using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<Symbol> sequence;
    public List<GameObject> sequenceBlocks;
    public PixelToWorld pxConverter;

    public enum Symbol
    {
         Nothing ,A, B, C, D, E, F
    }

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);

    }


}
