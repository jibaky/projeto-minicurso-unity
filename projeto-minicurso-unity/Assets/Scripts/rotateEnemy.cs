using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<enemyMovement>().walkRight = !collision.gameObject.GetComponent<enemyMovement>().walkRight;
    }
}
