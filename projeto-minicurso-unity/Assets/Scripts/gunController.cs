using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{
    public GameObject prefabTiro;
    public float fireRate = 1;
    float fireTimer;
    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;
        Debug.Log("firerate: "+fireRate+" firetimer: "+fireTimer);
        if(fireTimer > fireRate){
            Debug.Log("entrou no if");
            if(Input.GetMouseButton(0)){
                fireTimer = 0;
                Instantiate(prefabTiro, gameObject.transform.position, gameObject.transform.rotation);
            }
        }
    }
}
