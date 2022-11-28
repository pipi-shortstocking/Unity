using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ff");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.SetBool("doorOpened", true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetBool("doorOpened", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetTrigger("h");
        }
    }
    
}
