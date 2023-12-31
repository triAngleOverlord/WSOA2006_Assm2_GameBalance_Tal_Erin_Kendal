using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<Symbol> sequence = new List<Symbol> ();
    public List<Symbol> submission;
    public Level currentL;
    public static int numLevel;
    public static int wrong;

    public static int labelMax;
    public static int labelCurrent;

    public Image currentTile;
    public GameObject incorrectTXT;
    //public GameObject bookHolder;

    public enum Symbol
    {
         Nothing ,
        GBeetle, GVile, GWing, GEyeball, GEgg, GTooth, GCandy, GPlant, 
        BBeetle, BVile, BWing, BEyeball, BEgg, BTooth, BCandy, BPlant
    }


    public enum Level
    {
        menu ,one, two, three, four, five, end
    }

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance.gameObject);
        }
        else
        {
            Instance = this;
        }

        
        numLevel = 1;

        DontDestroyOnLoad(gameObject);

    }

    private void Start()
    {
        //bookHolder = GameObject.FindGameObjectWithTag("Book");
    }

    public void changeLevel(int level)
    {

        if (level == 1)
            currentL = Level.one;
        else if (level == 2)
            currentL = Level.two;
        else if (level == 3)
            currentL = Level.three;
        else if (level == 4)
            currentL = Level.four;
        else if (level == 5)
            currentL = Level.five;
        else if (level == 6)
            currentL = Level.end;


        switch (currentL)
        {
            case Level.one:
                SceneManager.LoadScene("LevelOne"); sequence.Clear(); 
                            sequence.Add(Symbol.GVile); sequence.Add(Symbol.GCandy); sequence.Add(Symbol.GBeetle);
                            labelMax = 4; 
                break;
            case Level.two:
                SceneManager.LoadScene("LevelTwo"); sequence.Clear();
                            sequence.Add(Symbol.GEyeball); sequence.Add(Symbol.GPlant); sequence.Add(Symbol.GWing);
                            labelMax = 4;
                break;
            case Level.three:
                SceneManager.LoadScene("LevelThree"); sequence.Clear();
                             sequence.Add(Symbol.GCandy); sequence.Add(Symbol.GEgg); sequence.Add(Symbol.GTooth);
                             labelMax = 3;
                break;
            case Level.four:
                SceneManager.LoadScene("LevelFour"); sequence.Clear();
                            sequence.Add(Symbol.BBeetle); sequence.Add(Symbol.GEyeball); sequence.Add(Symbol.GTooth); sequence.Add(Symbol.BEgg);
                labelMax = 3;
                break;
            case Level.five:
                SceneManager.LoadScene("LevelFive"); sequence.Clear();
                            sequence.Add(Symbol.GVile); sequence.Add(Symbol.BWing); sequence.Add(Symbol.BVile); sequence.Add(Symbol.GPlant);
                labelMax = 3;
                break;
            case Level.end: SceneManager.LoadScene("EndScene");
                break;
        }

        
        submission.Clear();
        wrong = 0;
        labelCurrent = 0;
    }


    public void checkSequence()//will be added to the apply button
    {
        
        submission.Clear();
        GameObject[] allSequenceObjects = GameObject.FindGameObjectsWithTag("Sequence");
        foreach (GameObject seqObject in allSequenceObjects)
            {
                submission.Add(seqObject.transform.GetComponent<GridSlot>().symbol);
            Debug.Log(seqObject.name);
            }

        if (sequence.Count != 0)
        {
            bool correct = true;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] != submission[i])
                {
                    Debug.Log(i.ToString()+ sequence[i] + "," + submission[i]);
                    correct = false;
                }

            }
            if (correct == true)
            {
                //next level load
                Debug.Log("You are correct!");
                numLevel++;
                changeLevel(numLevel);

            }
            else if (correct == false)
            {
                //display that the player is wrong
                wrong++;
                Debug.Log("You are incorrect!");
                Instantiate(incorrectTXT, GameObject.Find("Canvas").transform);

                if (wrong == 3)
                {
                    SceneManager.LoadScene("LoseScene");
                }

            }
        }

    }

    public void playBTN()
    {
        numLevel = 1;
        changeLevel(1);
    }

    public void tryAgain()
    {
        SceneManager.LoadScene("Menu");
    }
    

}
