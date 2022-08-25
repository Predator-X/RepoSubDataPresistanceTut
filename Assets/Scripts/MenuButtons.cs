using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuButtons : MonoBehaviour
{
   // public TextMeshPro inputField;
    public TMP_InputField inputField;
    public TMP_Text bestScoreText;
    public Button startButton, quitButton;
    public string nameHolder;
    GameObject MainManag;

    void Start()
    {
        // MainManag = GameObject.Find("MainManager");
        Save.Instance.LoadScore();
        bestScoreText.text = "Best Score : " + Save.Instance.Name + " : " + Save.Instance.Score ;
    }

    public void StartButtonClikced()
    {
       /* Debug.Log("i" + inputField.text);
        Save.Instance.LoadScore();
        if (Save.Instance.Name == inputField.ToString())
        {
            Save.Instance.LoadScore();
        }
        else
        {
            Save.Instance.Name = inputField.text.ToString();
        }
        */
        Save.Instance.nameHolder = inputField.text.ToString();
      
        
       // MainManag.GetComponent<MainManager>().PassName(inputField.text.ToString());
        SceneManager.LoadScene(1);
        
    }

    public void QuitButtonClicked()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    
}
