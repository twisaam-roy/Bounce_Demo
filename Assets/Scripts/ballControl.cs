using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControl : MonoBehaviour
{
    public float keyInput;
    public AudioSource ballTouchSound;
    // Start is called before the first frame update
    void Start()
    {
        ballTouchSound = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {

    if(Input.GetKeyDown(KeyCode.Space)){
        GetComponent<Rigidbody>().AddForce(Vector3.up*7,ForceMode.VelocityChange);
    }    

     keyInput = Input.GetAxis("Horizontal");
     GetComponent<Rigidbody>().velocity = new Vector3(keyInput,GetComponent<Rigidbody>().velocity.y,0);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("candy"))
        {
            ballTouchSound.Play();
        }
        if (collision.gameObject.CompareTag("Respawn"))
        {
            ballTouchSound.Play();
        }
    }
}
