using UnityEngine;
using System.Collections;

public class LanderControl : MonoBehaviour {

    Rigidbody2D rigid;
    public GameObject Lander;

	// Use this for initialization
	void Start () {
        rigid = Lander.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

       // Debug.Log(rigid.velocity.y);
        if (Input.GetKey(KeyCode.UpArrow))
        {

            if (rigid.velocity.y < 5)
                rigid.AddForce(new Vector2(0, 2));
        
        
        
        }

	
	}
}
