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
        Vector2 lookDirection = (_hael.transform.position - transform.position).normalized;

        _fireball.AddForce(lookDirection * speed);
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        Vector2 direction = otherPlayer.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, turnSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
    
   
    
}
