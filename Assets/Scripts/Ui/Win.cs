using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{


    public Button btnNextLevel;
    private void Start()
    {
        btnNextLevel.onClick.AddListener(() => NextLevelCallBack());
    }

    private void NextLevelCallBack()
    {
        SceneManager.LoadScene("Game");
    }


}
