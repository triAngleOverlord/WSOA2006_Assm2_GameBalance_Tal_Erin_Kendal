using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<Symbol> sequence = new List<Symbol> ();
    public List<Symbol> submission;
    public PixelToWorld pxConverter;
    public static Level currentL;

    public enum Symbol
    {
         Nothing ,A, B, C, D, E, F
    }

    public enum Level
    {
        one, two
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

        sequence.Add(Symbol.A);

    }

    public void changeSequenceRequirement()
    {
        switch (currentL)
        {
            case Level.one: sequence.Clear(); sequence.Add(Symbol.A); sequence.Add(Symbol.B); sequence.Add(Symbol.D); break;
        }
    }


    public void checkSequence()
    {
        bool correct = true;
        int i = 0;
        while (correct == true || i<sequence.Count)
        {
            if (sequence[i] == submission[i])
            {
                i++;
            }
            else
                correct = false;
        }


    }

    

}
