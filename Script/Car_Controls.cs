using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Controls : MonoBehaviour {
    public float Speed;
    private Rigidbody2D _rb;



    // Use this for initialization
    void Start () {
        _rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");


        Vector3 direction = new Vector3(moveHorizontal, 0f, 0f);
        transform.position += direction * Speed * Time.deltaTime;

    }
}
