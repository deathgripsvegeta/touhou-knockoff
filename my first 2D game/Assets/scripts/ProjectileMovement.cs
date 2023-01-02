using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileMovement : MonoBehaviour
{
    public float speed = 4;
    public float minRotation = 0;
    public float maxRotation = 360;

    private GameObject _player;
    private Rigidbody2D _fireball;


    // Start is called before the first frame update
    void Start()
    {
      _fireball = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private float RandomizeRotation()
    {
        return Random.Range(minRotation, maxRotation);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
    
   
    
}
