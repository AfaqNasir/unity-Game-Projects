using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    public float carSpeed;
    public float max_updown = 1.8f;
    public float min_updown = -2.0f;
    public float max_leftright = 3.8f;
    public float min_leftright = -3.9f;
    public GameObject PauseResumeButton;
    public GameObject PlayButton;
    Vector3 position;
    public uiManager ui;
    // Start is called before the first frame update
    void Start()
    {
        PauseResumeButton.SetActive(true);
        PlayButton.SetActive(false);
        position = transform.position;
      
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, min_leftright, max_leftright);
        position.y += Input.GetAxis ("Vertical") * carSpeed * Time.deltaTime;
        position.y = Mathf.Clamp (position.y, min_updown, max_updown);
        transform.position = position;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy Car") 
        {
            Destroy(gameObject);
            ui.CheckGameOver();
            ui.PauseResume();
            PauseResumeButton.SetActive(false);
            PlayButton.SetActive(true);
        }
    }
}
