using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{


    public GameObject PauseMenu;
    float pausetime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            
            PauseMenu.SetActive(!PauseMenu.activeInHierarchy);
            if (PauseMenu.activeInHierarchy)
            {
                
                pausetime = 0.0f;
            }
            else
            {
                pausetime = 1.0f;
            }
            Time.timeScale = pausetime;
        }
    }

    public void start()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
