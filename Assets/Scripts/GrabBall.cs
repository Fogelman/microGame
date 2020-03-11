using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBall : MonoBehaviour
{

    // GameManager para informar se perdeu a fase
	public GameObject gameManager;

	void Start() {
        // Coloca a bola em posições aleatórias
		transform.position = new Vector3( Random.Range(-6.0f, 6.0f), 3.0f, 0.0f);
	}

    void Update()
    {
        // Checa se a bola desceu demais (ou seja perdeu)
        if (transform.position.y < -2.5f)
        {
        	GetComponent<MeshRenderer>().material.color = Color.red;
        	gameManager.GetComponent<GameManager>().pass = false;
        }
    }
}
