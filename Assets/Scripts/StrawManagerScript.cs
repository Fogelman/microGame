using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawManagerScript : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    void Update () {
        int children = gameObject.transform.childCount;
        for (int i = 0; i < children; i++) {
            if (i < GameState.difficulty) {
                gameObject.transform.GetChild (i).gameObject.SetActive (true);
            } else {
                gameObject.transform.GetChild (i).gameObject.SetActive (false);
            }
        }
    }
}