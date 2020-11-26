using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

    public float speed = 0.0f;

    private Rigidbody2D rigidbody;
	// Use esto para la inicialización
	void Awake () {
        this.rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// La actualización se llama una vez por cuadro
	void FixedUpdate () {
        this.rigidbody.velocity = new Vector2(speed, 0);
        float parentPosition = this.transform.parent.transform.position.x;
        Debug.Log(parentPosition);

        if(this.transform.position.x - parentPosition >= 20.45f){
            this.transform.position = new Vector3(parentPosition-20.45f, this.transform.position.y, this.transform.position.z);
        }
	}
}
