using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SliderPlay : MonoBehaviour
{
    public int activeScene;
    public int nextScene;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left*UnityEngine.Random.Range(0.2f,1.2f),ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision) {

        if(collision.gameObject.CompareTag("candy")){
            SceneManager.LoadScene(nextScene);  
        }
        if(collision.gameObject.CompareTag("Respawn")){
            SceneManager.LoadScene(activeScene);
        }
    }
}
