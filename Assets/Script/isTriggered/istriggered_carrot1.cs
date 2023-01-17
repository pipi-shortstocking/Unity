using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot1 : MonoBehaviour
{
    public bool carrot1;

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
            carrot1 = true;
		}
	}
}
