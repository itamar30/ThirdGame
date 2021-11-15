using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
   
    
    void Update()
    {
        // while Player Object is Destoryed we would like to send game over
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
