using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class cutter : MonoBehaviour
{
    Vector3 randomAngle;
    public GameObject Knife;

    void OnTriggerEnter(Collider col)
    {
        int count = 0;
        if (col.gameObject.tag == "Slice")
        {   
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            col.gameObject.GetComponent<Rigidbody>().AddTorque(-Vector3.up * 12000f, ForceMode.Impulse);
            randomAngle = new Vector3(Random.Range(-0.8f, -2f), Random.Range(0.2f, 0.3f), Random.Range(-2f, 2f));

            col.gameObject.GetComponent<Rigidbody>().AddForce(randomAngle * Random.Range(1, 3), ForceMode.Impulse);

        }
    }

/*    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Slice" && Knife.GetComponent<Knife>().isCutting)
        {
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            col.gameObject.GetComponent<Rigidbody>().AddTorque(-Vector3.up * 12000f, ForceMode.Impulse);
            randomAngle = new Vector3(Random.Range(-0.8f, -2f), Random.Range(0.2f, 0.3f), Random.Range(-2f, 2f));

            col.gameObject.GetComponent<Rigidbody>().AddForce(randomAngle * Random.Range(650, 1500), ForceMode.Impulse);
            Knife.GetComponent<Knife>().SetCuttingState(true);

            Destroy(col.gameObject, 4f);
        }
    }*/
}
