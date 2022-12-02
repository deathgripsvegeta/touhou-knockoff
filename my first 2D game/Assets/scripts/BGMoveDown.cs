using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMoveDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 2;
    public bool IsGameActive = true;

    void Start()
    {
      if(IsGameActive == true)
      {
         transform.Translate(Vector2.down * moveSpeed * Time.deltaTime); 
      }
        
    }

    // Update is called once per frame
    void Update()
    {
     if(IsGameActive == true)
      {
         transform.Translate(Vector2.down * moveSpeed * Time.deltaTime); 
      }
    }
}
