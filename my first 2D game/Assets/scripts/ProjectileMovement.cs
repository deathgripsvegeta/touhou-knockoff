using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileMovement : MonoBehaviour
{
    public float speed = 4;


    private Vector3 _player;
    private GameObject _hael;
    private Rigidbody2D _fireball;
    public GameObject otherPlayer;
    public float turnSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        _hael = GameObject.Find("h.ael");
        _fireball = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDirection = (_hael.transform.position).normalized;

        _fireball.AddForce(lookDirection * speed);
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
    
   
    
}
