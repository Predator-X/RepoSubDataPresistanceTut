using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEntry : MonoBehaviour
{
    public string playerName;
    public int points;

    public InputEntry(string name, int score)
    {
        playerName = name;
        points = score;
    }


}