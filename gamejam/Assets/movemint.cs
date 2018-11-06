using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemint : MonoBehaviour {
    public float speed;
    public controler controller;
    Vector3 desierv;
    public float drag;
    float horizontal;
    float vertical;
    public Rigidbody rm;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        horizontal = controller.horizontal;
        Vector3 myright = new Vector3(horizontal, 0, 0);
        vertical = controller.vertical;
        Vector3 myup = new Vector3(0, 0, vertical);
        desierv = (myup + myright) * speed * Time.deltaTime;
        rm.velocity = desierv;
    }
}
