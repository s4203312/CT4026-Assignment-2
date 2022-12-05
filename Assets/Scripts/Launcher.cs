using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class Launcher : MonoBehaviour {

    private GameObject pinball;

    [SerializeField] private Options powervalue;
    private float power;

    private void Start()
    {
        pinball = GameObject.Find("Pinball");
    }

    public void launch() {
        power = powervalue.power;
        pinball.GetComponent<Rigidbody>().AddForce(Vector3.up * power);
    }
}