using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot5 : MonoBehaviour
{
    public bool carrot5;

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
            carrot5 = true;
		}
	}
}
