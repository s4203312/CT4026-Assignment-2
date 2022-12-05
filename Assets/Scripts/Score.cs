using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    float score = 300;

    void Start()
    {
        text.text = "Score: ";
    }
    private void OnCollisonEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            text.text += score;
        }
    }
}
