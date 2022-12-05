using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Flippers : MonoBehaviour
{
    private GameObject pinball;
    [SerializeField] public float power;

    private void Start() {
        pinball = GameObject.Find("Pinball");
        power = 400;
    }
    public void Flipper()
    {
        
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Flipper" ) {
            transform.GetComponent<Animator>().SetTrigger("UpdateState");
            pinball.GetComponent<Rigidbody>().AddForce(Vector3.up * power);
        }
    }
}
