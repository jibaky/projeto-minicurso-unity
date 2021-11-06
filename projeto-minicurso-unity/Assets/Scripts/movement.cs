using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float velocity = 0.1f;
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) ){
            gameObject.transform.position += gameObject.transform.right * -1 * velocity;
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) ){
            gameObject.transform.position += gameObject.transform.right * velocity;
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            gameObject.transform.position += gameObject.transform.up * velocity;
        }
    }
}
