using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sandwiches : MonoBehaviour
{
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int near_num;
    int far_num;
    TMP_Text info;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        //ray = new Ray(rigid.position, Vector3.down);
        info = GameObject.Find("info").GetComponent<TextMeshPro>();
    }

/*
    void FixedUpdate()
    {
        // Landing Platform
        Debug.DrawRay(rigid.position, Vector3.down, new Color(0,1,0));

        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Furniture"));

        if (rayHit.collider != null)
        {
            //Debug.Log(rayHit.collider.name);
            Debug.Log("hello");
            Debug.Log(rayHit.collider.name);
        }
    }
    */

    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);

        near_num = LayerMask.NameToLayer("near");
        far_num = LayerMask.NameToLayer("far");
        //Debug.Log(layerNum);
    }

    void FixedUpdate()
    {
        //Debug.Log(ray);
        //ray = new Ray(rigid.position, Vector3.down);
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        //if (Physics.Raycast(ray, 0.01f, worldLayer))
        if (Physics.Raycast(ray, 0.01f, 1 << near_num))
        {
            Debug.Log("near");
            //correct_near.SetActive(true);
            //wrong_near.SetActive(false);
            //near_clicked();
            info.text = "»÷µåÀ§Ä¡´Â °¡±îÀÌ µÎ¾îµµ ±¦Âú¾Æ¿ä!";
            info.color = new Color(0, 0, 1, 1);
        }
        else if (Physics.Raycast(ray, 0.01f, 1 << far_num))
        {
            Debug.Log("far");
            //correct_near.SetActive(false);
            //wrong_near.SetActive(true);
            //far_clicked();
            info.text = "»÷µåÀ§Ä¡´Â °¡±îÀÌ µÎ¾îµµ ±¦Âú¾Æ¿ä!";
            info.color = new Color(0, 0, 1, 1);
        }

        //Debug.Log(info.color);
    }
}
