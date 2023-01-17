using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carrotText : MonoBehaviour
{
    public GameObject Carrot1;
    public GameObject Carrot2;
    public GameObject Carrot3;
    public GameObject Carrot4;
    public GameObject Carrot5;
    public GameObject Carrot6;
    public GameObject Carrot7;
    public GameObject Carrot8;

    public GameObject first_text;
    public GameObject middle_text;
    public GameObject last_text;

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
        bool carrot1 = Carrot1.GetComponent<istriggered_carrot1>().carrot1;
        bool carrot2 = Carrot2.GetComponent<istriggered_carrot2>().carrot2;
        bool carrot3 = Carrot3.GetComponent<istriggered_carrot3>().carrot3;
        bool carrot4 = Carrot4.GetComponent<istriggered_carrot4>().carrot4;
        bool carrot5 = Carrot5.GetComponent<istriggered_carrot5>().carrot5;
        bool carrot6 = Carrot6.GetComponent<istriggered_carrot6>().carrot6;
        bool carrot7 = Carrot7.GetComponent<istriggered_carrot7>().carrot7;
        bool carrot8 = Carrot8.GetComponent<istriggered_carrot8>().carrot8;

        if (carrot1 == true || carrot2 == true || carrot3 == true || carrot4 == true ||
            carrot5 == true || carrot6 == true || carrot7 == true || carrot8 == true)
        {
            // ´Ù Àß¶ú´Ù¸é(if all cut)
            if (carrot2 == true && carrot3 == true && carrot4 == true &&
               carrot5 == true && carrot6 == true && carrot7 == true)
            {
                first_text.SetActive(false);
                middle_text.SetActive(false);
                last_text.SetActive(true);
                SceneManager.LoadScene(1);
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
