using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject eventSystem;
    public Button begin;
    public bool IsGameActive = true;
    // Start is called before the first frame update
    void Start()
    {
        IsGameActive = false;
        canvas.gameObject.SetActive(true);
        eventSystem.gameObject.SetActive(false);
        begin = GetComponent<Button>();
    }
    public void StartGame()
    {
        canvas.gameObject.SetActive(false);
        eventSystem.gameObject.SetActive(true);
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
