using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neon_sign_visibility : MonoBehaviour
{
    public Renderer custRender;
    // Start is called before the first frame update
    void Start()
    {
        custRender = GetComponent<Renderer>();
        custRender.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            custRender.enabled = false;
        }else if (Input.GetKey(KeyCode.Q))
        {
            custRender.enabled = true;
        }
    }
}
