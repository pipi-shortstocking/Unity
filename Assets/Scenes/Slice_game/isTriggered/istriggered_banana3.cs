using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_banana3 : MonoBehaviour
{
    public int banana3;

    // Start is called before the first frame update
    void Start()
    {
        banana3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            banana3 += 1;
		}
	}
}