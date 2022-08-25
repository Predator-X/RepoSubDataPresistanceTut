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
        Save.Instance.LoadScore();
        bestScoreText.text = "Best Score : " + Save.Instance.Name + " : " + Save.Instance.Score ;
    }

    public void StartButtonClikced()
    {

        Save.Instance.nameHolder = inputField.text.ToString();
      
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
