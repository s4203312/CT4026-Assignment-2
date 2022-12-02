using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Death : MonoBehaviour
{
    GameObject pinball;

    public UnityEvent DeathBox;

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    void death()
    {
        pinball = GameObject.Find("Pinball");
        Destroy(pinball);
        //Mabye add sound
        Instantiate(pinball, new Vector3(3.4f, -4.5f, 6.9f), Quaternion.identity);
    }
}
