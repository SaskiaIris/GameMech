using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static MonsterManager instance;
    public Text text;
    public int killed;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int value)
    {

        killed = killed + value;
        Debug.Log(killed);
        text.text = "Killed " + killed.ToString() + "/1";
 
    }
}
