using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazzleAutoOnData : MonoBehaviour
{
    public string namadrop;
    public GameObject pazzleDrop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == namadrop)
        {
            this.transform.position = pazzleDrop.transform.position;
            this.transform.rotation = pazzleDrop.transform.rotation;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == namadrop)
        {
            this.transform.position = this.transform.position;
            this.transform.rotation = this.transform.rotation;
        }
    }
}
