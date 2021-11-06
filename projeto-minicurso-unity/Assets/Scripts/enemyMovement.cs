using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float velocity = 0.1f;
    public bool walkRight = true;
    // Update is called once per frame
    void Update()
    {
        if(walkRight){
            gameObject.transform.position += gameObject.transform.right * -1 * velocity;
        }
        else{
            gameObject.transform.position += gameObject.transform.right * velocity;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision){
        walkRight = !walkRight;
    }
}
