using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemint : MonoBehaviour {
    public float speed;
    public float turnspeed;
    public controler controller;
    Vector3 desierv;
    public float height;

    public float drag;
    float horizontal;
    float vertical;
    public Rigidbody rm;
    Quaternion targertRotation;
    Transform cam;
    float angle;
    // Use this for initialization
    void Start () {
        cam = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
        horizontal = controller.horizontal;
        Vector3 myright = new Vector3(horizontal, 0, 0);
        vertical = controller.vertical;
        Vector3 myup = new Vector3(0, 0, vertical);
        desierv = (myup + myright) * speed * Time.deltaTime;
        rm.velocity = desierv;
        if(Mathf.Abs(horizontal)<1 && Mathf.Abs(vertical) < 1)
        {
            return;
        }
        angle = Mathf.Atan2(horizontal, vertical);
        angle = Mathf.Rad2Deg * angle;
        angle += cam.eulerAngles.y;
        targertRotation = Quaternion.Euler(0, angle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targertRotation, turnspeed * Time.deltaTime);
    }
}
