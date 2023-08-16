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

    public static int labelMax;
    public static int labelCurrent;

    public enum Symbol
    {
         Nothing ,A, B, C, D, E, F
    }

    public enum Level
    {
        one, two, three, four, five, six
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
            case Level.one: sequence.Clear(); 
                            sequence.Add(Symbol.A); sequence.Add(Symbol.B); sequence.Add(Symbol.D);
                            labelMax = 5;
                break;
            case Level.two: sequence.Clear();
                            sequence.Add(Symbol.A); sequence.Add(Symbol.B); sequence.Add(Symbol.D);
                            labelMax = 5;
                break;
            case Level.three:sequence.Clear();
                             sequence.Add(Symbol.A); sequence.Add(Symbol.B); sequence.Add(Symbol.D);
                             labelMax = 5;
                break;
            case Level.four:sequence.Clear();
                            sequence.Add(Symbol.A); sequence.Add(Symbol.B); sequence.Add(Symbol.D);
                            labelMax = 5;
                break;
            case Level.five:sequence.Clear();
                            sequence.Add(Symbol.A); sequence.Add(Symbol.B); sequence.Add(Symbol.D);
                            labelMax = 5;
                break;
            case Level.six: sequence.Clear();
                            sequence.Add(Symbol.A); sequence.Add(Symbol.B); sequence.Add(Symbol.D);
                            labelMax = 5;
                break;
        }

        submission.Clear();
        labelCurrent = 0;
    }


    public void checkSequence()//will be added to the apply button
    {
        submission.Clear();
        GameObject[] allSequenceObjects = GameObject.FindGameObjectsWithTag("Sequence");
        foreach (GameObject seqObject in allSequenceObjects)
        {
            submission.Add(seqObject.GetComponent<Symbol>());
        }

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

        if(correct == true)
        {
            //next level load
        }
        else
        {
            //display that the player is wrong
        }


    }

    

}
