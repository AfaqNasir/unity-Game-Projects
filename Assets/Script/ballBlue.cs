using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBlue : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballforce;
    bool gamestarted=false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && gamestarted==false)
        {
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballforce, ballforce));
            gamestarted = true;
        }    
    }
}
