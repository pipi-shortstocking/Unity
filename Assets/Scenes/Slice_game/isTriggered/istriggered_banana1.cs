using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_banana1 : MonoBehaviour
{
    public int banana1;

    // Start is called before the first frame update
    void Start()
    {
        banana1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            banana1 += 1;
		}
	}
}