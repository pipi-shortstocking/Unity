using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class rice : MonoBehaviour
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
        info = GameObject.Find("info").GetComponent<TextMeshPro>();
    }
    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);

        near_num = LayerMask.NameToLayer("near");
        far_num = LayerMask.NameToLayer("far");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        if (Physics.Raycast(ray, 0.01f, 1 << near_num))
        {
            Debug.Log("near");
            info.text = "ÁÖ¸Ô¹äÀº °¡±îÀÌ µÎ¾îµµ ±¦Âú¾Æ¿ä!";
            info.color = new Color(0, 0, 1, 1);
        }
        else if (Physics.Raycast(ray, 0.01f, 1 << far_num))
        {
            Debug.Log("far");
            info.text = "ÁÖ¸Ô¹äÀº °¡±îÀÌ µÎ¾îµµ ±¦Âú¾Æ¿ä!";
            info.color = new Color(0, 0, 1, 1);

        }
    }
}
