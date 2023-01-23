using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_banana6 : MonoBehaviour
{
    public int banana6;

    // Start is called before the first frame update
    void Start()
    {
        banana6 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            banana6 += 1;
		}
	}
}
