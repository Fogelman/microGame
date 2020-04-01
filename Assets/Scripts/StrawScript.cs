using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawScript : MonoBehaviour {

    public float speed;
    private GameObject player;
    private Vector3 direction;

    void Start () {
        player = GameObject.Find ("Turtle");
        direction = new Vector3 (0, 0, 0);
    }

    void Update () {
        float follow = Random.Range (0.0f, 1.0f);

        if (follow > 0.90f) {
            Vector3 random = new Vector3 (Random.Range (-1.0f, 1.0f), Random.Range (-1f, 1.0f), 0);
            direction = (player.transform.position + random) - gameObject.transform.position;
        }
        gameObject.transform.position += direction.normalized * speed * Time.deltaTime;
        transform.RotateAround (gameObject.transform.position, Vector3.forward, 90 * speed * Time.deltaTime);

    }
}