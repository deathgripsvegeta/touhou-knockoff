using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject GameOverCanvas;
    public GameObject eventSystem;
    public GameObject wizard;
    public Button Begin;
    public Button Exit;
    public bool IsGameActive = true;
    // Start is called before the first frame update
    void Start()
    {
        IsGameActive = false;
        Canvas.gameObject.SetActive(true);
        eventSystem.gameObject.SetActive(false);
        
    }
     public void GameOver()
    {
        IsGameActive = false;
        eventSystem.gameObject.SetActive(true);
        GameOverCanvas.gameObject.SetActive(true);
    }
    public void StartGame()
    {
        Canvas.gameObject.SetActive(false);
        eventSystem.gameObject.SetActive(true);
        wizard.gameObject.SetActive(true);
        IsGameActive = true;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
