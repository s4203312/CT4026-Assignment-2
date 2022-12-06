using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    [SerializeField] TMP_Text text;
    static public float score = 0;

    void Start() {
        text.text = "Score: " + score;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Target") {
            score = score + 300;
            text.text = "Score: " + score;
        }
    }
}
