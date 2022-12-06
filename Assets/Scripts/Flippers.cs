using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Flippers : MonoBehaviour {
    private GameObject pinball;
    [SerializeField] public float power;
    public Boolean pressed;

    private void Start() {
        pinball = GameObject.Find("Pinball");
        power = 700;
    }
    public void Flipper() {
        StartCoroutine(Flipping());
    }
    public IEnumerator Flipping() {
        transform.GetComponentInParent<Animator>().SetTrigger("UpdateState");
        pressed = true;
        yield return new WaitForSeconds(0.3f);
        pressed = false;
    }
    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "Pinball" && pressed == true) {
            pinball.GetComponent<Rigidbody>().AddForce(Vector3.up * power);
            pressed = false;
        }
    }
}
