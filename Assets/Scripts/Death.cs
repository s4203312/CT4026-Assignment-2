using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Death : MonoBehaviour {
    GameObject pinball;
    public int lives = 3;
    [SerializeField] TMP_Text text;
    [SerializeField] Button button;
    private int i = 1;
    GameObject LivesOBJ;
    [SerializeField] private Button launcher;

    void OnTriggerEnter(Collider other) {
        if (lives != 0) {
            if (other.tag == "Pinball") {
                pinball = GameObject.Find("Pinball");
                pinball.transform.position = new Vector3(3.4f, -4.5f, 6.9f);
                launcher.enabled = true;
                //Mabye add sound

                lives -= 1;
                LivesOBJ = GameObject.Find("Lives" + i);
                i++;
                Destroy(LivesOBJ);
            }
        }
        else {
            text.text = "Your out of pinballs. Final Score was: " + Score.score;
            Score.score = 0;
            button.gameObject.SetActive(true);
        }
    }
}