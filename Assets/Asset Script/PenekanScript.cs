using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenekanScript : MonoBehaviour
{
    public float translationSpeed = 1.0f;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Benda")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y+(translationSpeed * Time.deltaTime), transform.position.z);
        }
        
    }
    void OnTriggerStay(Collider other)
    {
        
       
    }
    void OnTriggerExit(Collider other)
    {
        
    }
}
