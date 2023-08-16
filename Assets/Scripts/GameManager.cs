using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<Symbol> sequence = new List<Symbol> ();
    public List<Symbol> submission;
    public PixelToWorld pxConverter;
    public static Level currentL;

    public static int labelMax;
    public static int labelCurrent;

    public SpriteRenderer currentTile;

    public enum Symbol
    {
         Nothing ,
        GBeetle, GVile, GWing, GEyeball, GEgg, GTooth, GCandy, GPlant, 
        BBeetle, BVile, BWing, BEyeball, BEgg, BTooth, BCandy, BPlant,
        YBeetle, YVile, YWing, YEyeball, YEgg, YTooth, YCandy, YPlant
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

        sequence.Add(Symbol.GBeetle);

    }

    public void changeLevel()
    {
        switch (currentL)
        {
            case Level.one: sequence.Clear(); 
                            sequence.Add(Symbol.GBeetle); sequence.Add(Symbol.GVile); sequence.Add(Symbol.GEyeball);
                            labelMax = 5;
                break;
            case Level.two: sequence.Clear();
                            sequence.Add(Symbol.GBeetle); sequence.Add(Symbol.GVile); sequence.Add(Symbol.GEyeball);
                            labelMax = 5;
                break;
            case Level.three:sequence.Clear();
                             sequence.Add(Symbol.GBeetle); sequence.Add(Symbol.GVile); sequence.Add(Symbol.GEyeball);
                             labelMax = 5;
                break;
            case Level.four:sequence.Clear();
                            sequence.Add(Symbol.GBeetle); sequence.Add(Symbol.GVile); sequence.Add(Symbol.GEyeball);
                            labelMax = 5;
                break;
            case Level.five:sequence.Clear();
                            sequence.Add(Symbol.GBeetle); sequence.Add(Symbol.GVile); sequence.Add(Symbol.GEyeball);
                            labelMax = 5;
                break;
            case Level.six: sequence.Clear();
                            sequence.Add(Symbol.GBeetle); sequence.Add(Symbol.GVile); sequence.Add(Symbol.GEyeball);
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
                submission.Add(seqObject.transform.GetComponent<GridSlot>().symbol);
            }

        bool correct = true;
        
        for (int i = 0; i < sequence.Count; i++)
        {
            if (sequence[i] != submission[i])
            {
                correct = false;
            }
              
        }

        if (correct == true)
        {
            //next level load
            Debug.Log("You are correct!");
            SceneManager.LoadScene("");
        }
        else
        {
            //display that the player is wrong
            Debug.Log("You are incorrect!");
        }





    }

    

}
