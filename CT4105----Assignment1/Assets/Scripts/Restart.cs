using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {

            //HealthScript.lives = 0;

            ResetScene();
            QuitGame();
            MainMenu();
        }

    }

    public void ResetScene()
    {

        Scene scene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(scene.name);

    }
    
    public void QuitGame()
    {

        Application.Quit();

    }
   
    public void MainMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }





    
    
    


}