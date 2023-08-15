using UnityEngine;
using System.Collections;

public class CheckCollision : MonoBehaviour {


    float vel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {

        


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            vel = collision.gameObject.GetComponent<Rigidbody2D>().velocity.y;
            if (vel > -0.2f)
            {

                Debug.Log("Good Landing");

            }
            else
            {
                Debug.Log("Bad Landing");

            }


        }
    }




}
