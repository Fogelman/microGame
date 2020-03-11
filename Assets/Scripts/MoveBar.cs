using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBar : MonoBehaviour
{

    // GameManager para recuperar nível atual
    public GameObject gameManager;

	void Start() {
        // Diminui o tamanho da base conforme fases avançam
    	int level = gameManager.GetComponent<GameManager>().level();
    	if(level==2) {
    		transform.localScale = new Vector3(2.0f,0.2f,1.0f);
    	} else if(level==3) {
    		transform.localScale = new Vector3(1.0f,0.2f,1.0f);
    	}
    }

    void Update()
    {
        // Desloca base para a esquerda e direita
    	float dh = Input.GetAxis("Horizontal") * Time.deltaTime;
        if (( transform.position.x > -8 || dh > 0) &&
            ( transform.position.x <  8 || dh < 0))
        {
            gameObject.transform.position += Vector3.right * dh * 10.0f;
        }
    }
}
