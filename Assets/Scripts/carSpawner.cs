using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    public GameObject[] car;
    int carNo;
    public float maxPos = 1.8f;
    public float minPos = -2.0f;
    public float delayTimer = 1f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(transform.position.x, Random.Range(minPos, maxPos), transform.position.z);
            carNo = Random.Range(0,11);
            Instantiate(car[carNo], carPos, transform.rotation);
            timer = delayTimer;
        }
    }
}
