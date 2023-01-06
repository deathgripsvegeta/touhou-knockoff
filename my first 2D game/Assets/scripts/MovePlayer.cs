using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5;
    public GameObject hitbox;
    public GameObject bullets;
    public GameObject slowBullets;
    private bool _ismovementslow;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime); 
        SlowerMovement();
        Shoot();

       
    }
    public void SlowerMovement()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 2;
            hitbox.gameObject.SetActive(true);
            _ismovementslow = true;
            
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
           speed = 5;
           hitbox.gameObject.SetActive(false);
           _ismovementslow = false;
        }

    }
    public void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            bullets.gameObject.SetActive(true);
            if(_ismovementslow)
            {
                slowBullets.gameObject.SetActive(true);
            }

        }
        if(Input.GetKeyUp(KeyCode.Z))
        {
            bullets.gameObject.SetActive(false);
        }

    }
    
}
