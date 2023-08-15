using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMove : MonoBehaviour
{
    public float speed;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update() {
        offset = new Vector2(Time.time * speed, 0);

        GetComponent<Renderer> ().material.mainTextureOffset = offset;
    }
}
