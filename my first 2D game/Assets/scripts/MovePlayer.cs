using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5;
    public GameObject hitbox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime); 
        SlowerMovement();
       
    }
    public void SlowerMovement()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 2;
            hitbox.gameObject.SetActive(true);
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
           speed = 5;
           hitbox.gameObject.SetActive(false);
        }
    }
}
