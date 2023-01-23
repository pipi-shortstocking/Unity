using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_banana2 : MonoBehaviour
{
    public int banana2;

    // Start is called before the first frame update
    void Start()
    {
        banana2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            banana2 += 1;
		}
	}
}
