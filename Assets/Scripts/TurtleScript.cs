using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleScript : MonoBehaviour {

    public GameObject gameManager;
    private int level;
    private bool pass;

    void Start () {
        pass = true;
        gameObject.transform.position = new Vector3 (Random.Range (-3.0f, 3.0f), Random.Range (-3.0f, 3.0f), 0);
        gameManager = GameObject.Find ("Canvas");
    }

    void Update () {
        var turtleSpeed = 10.0f;

        Vector3 nextPosition = gameObject.transform.position;
        float x = Input.GetAxis ("Horizontal");
        float z = Input.GetAxis ("Vertical");

        if ((transform.position.x > -9 || x > 0) &&
            (transform.position.x < 9 || x < 0)) {
            gameObject.transform.position += Vector3.right * x * turtleSpeed * Time.deltaTime;
        }

        if ((transform.position.y > -4 || z > 0) &&
            (transform.position.y < 5 || z < 0)) {
            gameObject.transform.position += Vector3.up * z * turtleSpeed * Time.deltaTime;
        }

    }

    void OnTriggerEnter2D (Collider2D collision) {

        if (collision.tag == "Straw" && pass) {
            pass = false;
            gameManager.GetComponent<GameManager> ().pass = pass;
        }

    }
}