using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class Launcher : MonoBehaviour {

    private GameObject pinball;
    [SerializeField] public float power;
    [SerializeField] public Slider slider;

    private void Start()
    {
        pinball = GameObject.Find("Pinball");
    }

    public void launch() {
        pinball.GetComponent<Rigidbody>().AddForce(Vector3.up * power);
    }

    public void Update()
    {
        power = slider.value;
    }
}