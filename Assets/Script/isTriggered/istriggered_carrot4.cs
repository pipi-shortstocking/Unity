using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot4 : MonoBehaviour
{
    public bool carrot4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            carrot4 = true;
		}
	}
}
