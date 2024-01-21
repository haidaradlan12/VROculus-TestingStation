using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazzleData : MonoBehaviour
{
    public GameObject[] pazzleDrop;
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
        if (other.gameObject.name == "Drop Puzzle 1")
        {
            this.transform.position = pazzleDrop[0].transform.position;
            this.transform.rotation = pazzleDrop[0].transform.rotation;
        }
        if (other.gameObject.name == "Drop Puzzle 2")
        {
            this.transform.position = pazzleDrop[1].transform.position;
            this.transform.rotation = pazzleDrop[1].transform.rotation;
        }
        if (other.gameObject.name == "Drop Puzzle 3")
        {
            this.transform.position = pazzleDrop[2].transform.position;
            this.transform.rotation = pazzleDrop[2].transform.rotation;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Drop Puzzle 1")
        {
            this.transform.position = this.transform.position;
            this.transform.rotation = this.transform.rotation;
        }
        if (other.gameObject.name == "Drop Puzzle 2")
        {
            this.transform.position = this.transform.position;
            this.transform.rotation = this.transform.rotation;
        }
        if (other.gameObject.name == "Drop Puzzle 3")
        {
            this.transform.position = this.transform.position;
            this.transform.rotation = this.transform.rotation;
        }
    }
}
