using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 start = new Vector3(0, 0, 0);
    Vector3 destination = new Vector3(1,0, 0);

    void Update()
    {
        Vector3 speed = Vector3.zero; // (0,0,0) 은 .zero 로도 표현가능
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref speed, 10);
    }

}
