using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileMovement : MonoBehaviour
{
    public float speed = 4;
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
      _player = GameObject.Find("h.ael");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
    
   
    
}
