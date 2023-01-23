using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_banana8 : MonoBehaviour
{
    public int banana8;

    // Start is called before the first frame update
    void Start()
    {
        banana8 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            banana8 += 1;
		}
	}
}
