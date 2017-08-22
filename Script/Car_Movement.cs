using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Movement : MonoBehaviour {
  public float speed = 15f;
	// Use this for initialization
	void Start () {
        
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed, ForceMode2D.Force);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
