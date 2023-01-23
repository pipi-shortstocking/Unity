using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bananaText : MonoBehaviour
{
    public GameObject Banana1;
    public GameObject Banana2;
    public GameObject Banana3;
    public GameObject Banana4;
    public GameObject Banana5;
    public GameObject Banana6;
    public GameObject Banana7;
    public GameObject Banana8;
    public GameObject Banana9;

    public GameObject first_text;
    public GameObject middle_text;
    public GameObject last_text;

    bool banana1, banana2, banana3, banana4, banana5, banana6, banana7, banana8, banana9;

    // Start is called before the first frame update
    void Start()
    {
        first_text.SetActive(true);
        middle_text.SetActive(false);
        last_text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
/*        banana1 = Banana1.GetComponent<istriggered_banana1>().banana1;
        banana2 = Banana2.GetComponent<istriggered_banana2>().banana2;
        banana3 = Banana3.GetComponent<istriggered_banana3>().banana3;
        banana4 = Banana4.GetComponent<istriggered_banana4>().banana4;
        banana5 = Banana5.GetComponent<istriggered_banana5>().banana5;
        banana6 = Banana6.GetComponent<istriggered_banana6>().banana6;
        banana7 = Banana7.GetComponent<istriggered_banana7>().banana7;
        banana8 = Banana8.GetComponent<istriggered_banana8>().banana8;
        banana9 = Banana9.GetComponent<istriggered_banana9>().banana9;*/

        if (banana1 == true || banana2 == true || banana3 == true || banana4 == true || banana5 == true ||
            banana6 == true || banana7 == true || banana8 == true || banana9 == true)
        {
            // ´Ù Àß¶ú´Ù¸é(if all cut)
            if (banana2 == true && banana3 == true && banana4 == true && banana5 == true &&
                banana6 == true && banana7 == true && banana8 == true)
            {
                first_text.SetActive(false);
                middle_text.SetActive(false);
                last_text.SetActive(true);
            }
            // ¾ÆÁ÷ ´ú Àß¶ú´Ù¸é(if not all cut)
            else
            {
                first_text.SetActive(false);
                middle_text.SetActive(true);
                last_text.SetActive(false);
			}
        }
    }
}
