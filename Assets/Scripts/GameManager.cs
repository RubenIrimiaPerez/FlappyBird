using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{

    public bool muerto = false;
    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;

    public static GameManager Instance { get { return instance; } }


    private void Awake()
    {
        if (instance == null)
        { 
            instance = this;
        }

        Time.timeScale = 1f;
    }

    
   public  void GameOver()
    {
        muerto = true;
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        
    }

    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
