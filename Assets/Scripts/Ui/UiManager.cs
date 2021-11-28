using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager Instance = null;
    public GameObject levelCompletePrefab;
    public GameObject levelFailedPrefab;


    public void Awake()
    {
        if (Instance == null) Instance = this;
       
    }


    public void LoadLevelComplete()
    {
        Instantiate(levelCompletePrefab, this.transform);
      
    }

    public void LoadLevelFailed()
    {
        Instantiate(levelFailedPrefab, this.transform);
    }
}
