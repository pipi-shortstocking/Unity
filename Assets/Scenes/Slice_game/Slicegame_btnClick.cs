using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicegame_btnClick : MonoBehaviour
{
    public GameObject bowl_in_carrot;
    public GameObject Carrot;

    // Start is called before the first frame update
    void Start()
    {
        bowl_in_carrot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Slicegame_btn()
	{
        bowl_in_carrot.SetActive(true);
        Carrot.SetActive(false);
	}
}
