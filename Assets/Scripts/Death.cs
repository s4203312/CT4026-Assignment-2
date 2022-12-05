using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    GameObject pinball;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pinball")
        {
            pinball = GameObject.Find("Pinball");
            pinball.transform.position = new Vector3(3.4f, -4.5f, 6.9f);
            //Mabye add sound
        }
    }
}
