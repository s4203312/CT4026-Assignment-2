using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UIElements;

public class Launcher : MonoBehaviour {
    private GameObject pinball;

    public void launch() {
        pinball = GameObject.Find("Pinball");
        pinball.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000f);
    }
}