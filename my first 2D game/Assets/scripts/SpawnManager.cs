using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject projectile1;
    public GameObject projectile2;
    public GameObject projectile3;
    public GameObject projectile4;
    public GameObject spell1;
    public GameObject spell2;
    public GameObject spell3;
    public int SpellCardCount = 1;
    public float spawnPosX = 0;
    public float spawnPosY = 2;
    public float RotatZ = 0;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(projectile1, GenerateSpawnRotation(), projectile1.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GenerateSpawnRotation()
    {
        float RotatZ = Random.Range(0, 360);
        Vector3 randomPos = new Vector3(RotatZ, 360);
        return randomPos;
        Vector2 randomPos = new Vector2(spawnPosX, spawnPosY);
    }
   
}   
