using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float velocity = 0.1f;

    Rigidbody playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) ){
            gameObject.transform.position += gameObject.transform.forward * velocity;
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) ){
            gameObject.transform.position += gameObject.transform.forward * -1 * velocity;
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) ){
            gameObject.transform.position += gameObject.transform.right * -1 * velocity;
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) ){
            gameObject.transform.position += gameObject.transform.right * velocity;
        }
        if(Input.GetKey(KeyCode.Space)){
            gameObject.transform.position += gameObject.transform.up * velocity;
        }
    }
}
