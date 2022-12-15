using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool IsGameActive = true;
    public List<GameObject> projectile;
    public float xPos = 0;
    public float yPos = 2;

    // Start is called before the first frame update
    void Start()
    {
        IsGameActive = false;
    }
    public void StartGame()
    {
        IsGameActive = true;
        StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int spawnPlace;
    IEnumerator SpawnTarget()
    {
        while(IsGameActive)
        {
            yield return new WaitForSeconds(1);
            
            Instantiate<GameObject>(projectile[1]);
            
        }
    }
   
}
