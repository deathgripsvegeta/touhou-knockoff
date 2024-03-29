using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool IsGameActive = true;
    
    public List<GameObject> projectile;
        private Vector3 _spawnPos = new Vector3(0, 2, 0);

    // Start is called before the first frame update
    void Start()
    {
        IsGameActive = false;
        StartGame();
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
            yield return new WaitForSeconds(1f);
            int index = Random.Range(0, 3);
            Instantiate(projectile[index]);
            
            
        }
    }
   
}
