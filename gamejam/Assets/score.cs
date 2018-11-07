using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public float score1;
    public Text text;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        text.text = "Score " + score1.ToString();
        if(score1 >= 20)
        {
            text.text = "you win";
        }
    }
    private void OnCollisionEnter(Collision hit)
    {
        if(hit.gameObject.tag == "wall")
        {
            score1 += 1;
        }
    }
}
