using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public void Flipper()
    {
        transform.GetComponent<Animator>().SetTrigger("UpdateState");
    }
}
