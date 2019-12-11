﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string teamSelection;
    public string leagueSetUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExhibitionMatch(){
        SceneManager.LoadScene(teamSelection);
    }

    public void ExitGame(){
        Application.Quit();
    }
}
