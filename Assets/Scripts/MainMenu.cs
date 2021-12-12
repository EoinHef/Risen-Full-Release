using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playButton;

    public Button exitButton;
    //Cresting a reference to the first game scene
    public string newGameScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Logic for button on the main menu
    public void NewGame()
    {
        //Starts a new game on button press
        SceneManager.LoadScene(newGameScene);
    }

    public void QuitGame()
    {
        //Quits application on button press on main menu
        Application.Quit();
    }
}
