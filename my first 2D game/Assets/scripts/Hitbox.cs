using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hitbox : MonoBehaviour
{
    public GameObject hitbox;
    
    // Start is called before the first frame update
    void Start()
    {
       hitbox.gameObject.SetActive(false);
       hide = true;
       ShowHitBox();
    }
    public bool hide = true;

    public void ShowHitBox()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            hitbox.gameObject.SetActive(true);
            hide = false;
        }
    }
    void Update()
    {
       
    }
}
