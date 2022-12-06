using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public bool LeftShiftDown = false;
    public float speed = 5;
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
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            LeftShiftDown = true;
        }

    }
    public void SlowerMovement()
    {
        if(LeftShiftDown == true)
        {
            speed = 2;
        }
    }
}
