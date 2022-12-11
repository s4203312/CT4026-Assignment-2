using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    [SerializeField] TMP_Text text;
    static public float score = 0;

    void Start() {                      //Setting the text on the screen
        text.text = "Score: " + score;
    }

    private void OnCollisionEnter(Collision collision) {        //Checking whether a collison has happened between the pinball and the targets
        if (collision.gameObject.tag == "Target") {
            score = score + 300;                                //Updating the score
            text.text = "Score: " + score;
            transform.GetComponent<AudioSource>().Play();       //Playing a sound as a cue that you scored points
        }
        else if (collision.gameObject.tag == "Target1") {
            score = score + 600;
            text.text = "Score: " + score;
            transform.GetComponent<AudioSource>().Play();
        }
        else if (collision.gameObject.tag == "Target2") {
            score = score - 100;
            text.text = "Score: " + score;
            transform.GetComponent<AudioSource>().Play();
        }
    }
}
