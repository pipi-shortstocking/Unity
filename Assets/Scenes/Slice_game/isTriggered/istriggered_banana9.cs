using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_banana9 : MonoBehaviour
{
    public int banana9;

    // Start is called before the first frame update
    void Start()
    {
        banana9 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            banana9 += 1;
		}
	}
}
