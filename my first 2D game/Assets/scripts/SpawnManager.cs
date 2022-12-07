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
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(projectile1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
