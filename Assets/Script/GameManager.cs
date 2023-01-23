using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int point;
    GameObject Finish;

    void FixedUpdate()
    {
        Finish = GameObject.FindGameObjectWithTag("Finish");
        if(point >= 6)
        {
            //Finish.SetActive(true);
            Debug.Log("³¡");
        }
    }
}
