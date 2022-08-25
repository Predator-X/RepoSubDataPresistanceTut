using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InputHandler : MonoBehaviour
{
   // [System.Serializable] InputField nameInput;
    public TMP_InputField nameInput;

    List<InputEntry> entries = new List<InputEntry>();

    public void AddNameToList()
    {
        entries.Add(new InputEntry(nameInput.text, Random.Range(0, 100)));
        nameInput.text = "";
    }
}
